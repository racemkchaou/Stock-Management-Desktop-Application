using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using StockApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DevExpress.XtraEditors;
using StockApp.Views;
using System.Windows.Forms;
using StockApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using DevExpress.XtraReports.UI;
using StockApp.XtraReports;

namespace StockApp.ViewModels
{
    public class BonLivraisonViewModel : ViewModelBase
    {
        private AppDbContext _context;

        public BonLivraisonFacture CurrentBonLivraison { get; set; }
        public ObservableCollection<LigneBonLivraisonFacture> LignesBonLivraison { get; set; }
        public ObservableCollection<FicheClient> Clients { get; set; }
        public ObservableCollection<BonCommande> BonCommandes { get; set; }
        public ObservableCollection<FicheArticle> Articles { get; set; }


        public ICommand AjouterLigneCommand { get; }
        public ICommand EnregistrerCommand { get; }
        public ICommand ImprimerCommand { get; }

        public BonLivraisonViewModel()
        {
            _context = new AppDbContext();

            CurrentBonLivraison = new BonLivraisonFacture
            {
                DateBlf = DateOnly.FromDateTime(DateTime.Today),
                LigneBonLivraisonFactures = new List<LigneBonLivraisonFacture>()
            };

            LignesBonLivraison = new ObservableCollection<LigneBonLivraisonFacture>();
            Clients = new ObservableCollection<FicheClient>(_context.FicheClients.ToList());
            BonCommandes = new ObservableCollection<BonCommande>(_context.BonCommandes.ToList());
            Articles = new ObservableCollection<FicheArticle>(_context.FicheArticles.ToList());


            // Initialisation correcte des commandes
            AjouterLigneCommand = new DelegateCommand(AjouterLigne);
            EnregistrerCommand = new DelegateCommand(Enregistrer);
            ImprimerCommand = new DelegateCommand(Imprimer);
        }

        private LigneBonLivraisonFacture _nouvelleLigne;

        public void SetLigneToAdd(LigneBonLivraisonFacture ligne)
        {
            _nouvelleLigne = ligne;
        }

        private decimal? _displayTotal;
        public decimal? DisplayTotal
        {
            get => _displayTotal;
            set
            {
                _displayTotal = value;
                RaisePropertyChanged(nameof(DisplayTotal));
            }
        }

        public void CalculerTotal()
        {
            CurrentBonLivraison.MontantTotal = LignesBonLivraison.Sum(l => l.Total);
            DisplayTotal = CurrentBonLivraison.MontantTotal; // Mise à jour de la propriété bindable
        }

        private bool _disposed = false;
                
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }


        public void AjouterLigne()
        {
            if (_nouvelleLigne == null) return;

            // Détacher l'article de la nouvelle ligne
            if (_nouvelleLigne.CodeArticleNavigation != null)
            {
                _context.Entry(_nouvelleLigne.CodeArticleNavigation).State = EntityState.Detached;
            }

            // Vérifier si l'article existe déjà dans le bon
            var ligneExistante = LignesBonLivraison
                .FirstOrDefault(l => l.CodeArticle == _nouvelleLigne.CodeArticle);

            if (ligneExistante != null)
            {
                // Supprimer l'ancienne ligne
                LignesBonLivraison.Remove(ligneExistante);
                CurrentBonLivraison.LigneBonLivraisonFactures.Remove(ligneExistante);
            }

            // Créez une NOUVELLE instance de ligne avec toutes les propriétés
            var ligneAAjouter = new LigneBonLivraisonFacture
            {
                CodeArticle = _nouvelleLigne.CodeArticle,
                Designation = _nouvelleLigne.CodeArticleNavigation?.Designation ?? _nouvelleLigne.Designation,
                Quantite = _nouvelleLigne.Quantite,
                PrixUnitaire = _nouvelleLigne.PrixUnitaire,
                Total = _nouvelleLigne.Quantite * _nouvelleLigne.PrixUnitaire,
                NumeroBlf = CurrentBonLivraison.NumeroBlf,
                // Conservez la référence à l'article si nécessaire
                CodeArticleNavigation = _nouvelleLigne.CodeArticleNavigation
            };

            LignesBonLivraison.Add(ligneAAjouter);
            CurrentBonLivraison.LigneBonLivraisonFactures.Add(ligneAAjouter);

            CalculerTotal();
            _nouvelleLigne = null;
        }
        public bool EnregistrementReussi { get; private set; }

        public void Enregistrer()
        {
            EnregistrementReussi = false;

            try
            {
                CurrentBonLivraison.MontantTotal = LignesBonLivraison.Sum(l => l.Total);

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        // Vider le suivi des entités pour éviter les doublons
                        _context.ChangeTracker.Clear();

                        // Ajoutez cette vérification au début
                        bool isNew = CurrentBonLivraison.NumeroBlf == 0;
                        decimal ancienMontantBon = 0m;

                        // Mettre à jour le TotalDesVentes du client
                        var client = _context.FicheClients.Find(CurrentBonLivraison.CodeClient);
                        if (client != null)
                        {

                            // Si c'est une modification, récupérer l'ancien montant
                            if (!isNew)
                            {
                                var ancienBon = _context.BonLivraisonFactures
                                    .AsNoTracking()
                                    .FirstOrDefault(b => b.NumeroBlf == CurrentBonLivraison.NumeroBlf);

                                if (ancienBon != null)
                                {
                                    ancienMontantBon = ancienBon.MontantTotal ?? 0m;
                                    // Soustraire l'ancien montant du total des ventes
                                    client.TotalDesVentes -= ancienMontantBon;
                                }
                            }

                            // 1. Arrondir le montant du bon à 4 décimales
                            decimal montantArrondi = Math.Round(CurrentBonLivraison.MontantTotal ?? 0m, 4);

                            // 2. Calculer le nouveau total avec vérification de limite
                            decimal nouveauTotal = (client.TotalDesVentes ?? 0m) + montantArrondi;

                            // 3. Vérification explicite du dépassement (pour decimal(18,4))
                            decimal limiteMax = 999999999999.9999m; // 14 chiffres avant, 4 après

                            if (nouveauTotal > limiteMax)
                            {
                                XtraMessageBox.Show($"Le total des ventes ne peut pas dépasser {limiteMax:N2}",
                                                  "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // 4. Appliquer la valeur arrondie
                            client.TotalDesVentes = Math.Round(nouveauTotal, 4);
                            _context.Entry(client).State = EntityState.Modified;
                        }

                        // 1. Enregistrer le bon de livraison
                        if (isNew)
                        {
                            _context.BonLivraisonFactures.Add(CurrentBonLivraison);
                        }
                        else
                        {
                            // Pour une modification, attacher l'entité existante
                            var existingBon = _context.BonLivraisonFactures
                                .Include(b => b.LigneBonLivraisonFactures)
                                .FirstOrDefault(b => b.NumeroBlf == CurrentBonLivraison.NumeroBlf);

                            if (existingBon != null)
                            {
                                // Mettre à jour les propriétés du bon existant
                                _context.Entry(existingBon).CurrentValues.SetValues(CurrentBonLivraison);
                                // Supprimer les anciennes lignes
                                _context.LigneBonLivraisonFactures.RemoveRange(existingBon.LigneBonLivraisonFactures);
                            }
                        }

                        _context.SaveChanges(); // Sauvegarde le bon (nouveau ou modifié)

                        // 2. Enregistrer les lignes (version optimisée)
                        var lignesDistinctes = LignesBonLivraison
                            .GroupBy(l => new { l.CodeArticle, l.Quantite, l.PrixUnitaire })
                            .Select(g => g.First());

                        foreach (var ligne in lignesDistinctes)
                        {
                            var newLigne = new LigneBonLivraisonFacture
                            {
                                NumeroBlf = CurrentBonLivraison.NumeroBlf,
                                CodeArticle = ligne.CodeArticle,
                                Designation = ligne.Designation,
                                Quantite = ligne.Quantite,
                                PrixUnitaire = ligne.PrixUnitaire,
                                Total = ligne.Total
                            };

                            // Vérifier si la ligne existe déjà
                            bool existeDeja = _context.LigneBonLivraisonFactures
                                .Any(l => l.NumeroBlf == CurrentBonLivraison.NumeroBlf
                                       && l.CodeArticle == newLigne.CodeArticle);

                            if (!existeDeja)
                            {
                                _context.LigneBonLivraisonFactures.Add(newLigne);
                            }
                            // Mettre à jour le stock
                            var article = _context.FicheArticles.Find(ligne.CodeArticle);
                            if (article != null)
                            {
                                /*
                                if (ligne.Quantite > article.QuantiteEnStock)
                                {
                                    string message = $"La quantité en stock de l'article {article.Designation} est insuffisante" +
                                                    $"Voulez-vous quand même continuer?";

                                    DialogResult result = XtraMessageBox.Show(
                                        message, "Avertissement",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Warning);

                                    if (result != DialogResult.Yes)
                                    {
                                        return; 
                                    }
                                }
                                */


                                article.QuantiteEnStock -= ligne.Quantite;
                                _context.Entry(article).State = EntityState.Modified;
                            }
                        }

                        _context.SaveChanges();
                        transaction.Commit();
                        EnregistrementReussi = true;

                        XtraMessageBox.Show("Enregistrement réussi! Stock mis à jour", "Succès",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ShowErrorDetails(ex);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowErrorDetails(ex);
            }
        }
        private void ShowErrorDetails(Exception ex)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Erreur lors de l'enregistrement:");

            // Ajouter le logging pour le débogage
            System.Diagnostics.Debug.WriteLine("ERREUR: " + ex.ToString());

            while (ex != null)
            {
                sb.AppendLine(ex.Message);
                if (ex is DbUpdateException dbEx)
                {
                    foreach (var entry in dbEx.Entries)
                    {
                        sb.AppendLine($"Entité en conflit: {entry.Entity.GetType().Name}");
                    }
                }
                ex = ex.InnerException;
            }

            XtraMessageBox.Show(sb.ToString(), "Erreur",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // Ajoutez cette méthode dans votre BonLivraisonViewModel
        private void Imprimer()
        {
            try
            {
                // Vérifier qu'il y a des lignes à imprimer
                if (LignesBonLivraison == null || LignesBonLivraison.Count == 0)
                {
                    XtraMessageBox.Show("Aucune ligne à imprimer.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Créer le rapport
                var report = new BonLivraisonReport(
                    CurrentBonLivraison,
                    new List<LigneBonLivraisonFacture>(LignesBonLivraison));

                // Afficher l'aperçu avant impression
                using (var printTool = new ReportPrintTool(report))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Erreur lors de l'impression : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SupprimerAncienBonSiExistant()
        {
            var bonExistant = _context.BonLivraisonFactures
                .Include(b => b.LigneBonLivraisonFactures)
                .FirstOrDefault(b => b.NumeroBc == CurrentBonLivraison.NumeroBc);

            if (bonExistant != null)
            {
                // Restaurer le stock si nécessaire
                foreach (var ligne in bonExistant.LigneBonLivraisonFactures)
                {
                    var article = _context.FicheArticles.Find(ligne.CodeArticle);
                    if (article != null)
                    {
                        article.QuantiteEnStock += ligne.Quantite;
                        _context.Entry(article).State = EntityState.Modified;
                    }
                }

                // Supprimer les lignes puis le bon
                _context.LigneBonLivraisonFactures.RemoveRange(bonExistant.LigneBonLivraisonFactures);
                _context.BonLivraisonFactures.Remove(bonExistant);
                _context.SaveChanges();
            }
        }


        public void ChargerBonLivraison(int numeroBlf)
        {
            // Détacher toutes les entités suivies
            _context.ChangeTracker.Clear();

            var bon = _context.BonLivraisonFactures
                .AsNoTracking() // Important pour éviter les conflits
                .Include(b => b.LigneBonLivraisonFactures)
                .FirstOrDefault(b => b.NumeroBlf == numeroBlf);

            if (bon != null)
            {
                // Détacher les articles des lignes avant l'assignation
                foreach (var ligne in bon.LigneBonLivraisonFactures)
                {
                    ligne.CodeArticleNavigation = null;
                }

                CurrentBonLivraison = bon;
                LignesBonLivraison = new ObservableCollection<LigneBonLivraisonFacture>(bon.LigneBonLivraisonFactures);

                RaisePropertyChanged(nameof(CurrentBonLivraison));
                RaisePropertyChanged(nameof(LignesBonLivraison));
            }
        }
        public void SupprimerLigne(LigneBonLivraisonFacture ligne)
        {
            if (ligne != null)
            {
                LignesBonLivraison.Remove(ligne);
                CurrentBonLivraison.LigneBonLivraisonFactures.Remove(ligne);
                CalculerTotal();
            }
        }

        public LigneBonLivraisonFacture GetCopieLignePourEdition(LigneBonLivraisonFacture ligne)
        {
            if (ligne == null) return null;

            return new LigneBonLivraisonFacture
            {
                CodeArticle = ligne.CodeArticle,
                Designation = ligne.Designation,
                Quantite = ligne.Quantite,
                PrixUnitaire = ligne.PrixUnitaire,
                Total = ligne.Total
            };
        }

        public void ChargerLignePourModification(LigneBonLivraisonFacture ligne)
        {
            if (ligne == null) return;

            _nouvelleLigne = new LigneBonLivraisonFacture
            {
                CodeArticle = ligne.CodeArticle,
                Designation = ligne.Designation,
                Quantite = ligne.Quantite,
                PrixUnitaire = ligne.PrixUnitaire,
                Total = ligne.Total,
                CodeArticleNavigation = Articles.FirstOrDefault(a => a.CodeArticle == ligne.CodeArticle)
            };
        }

        public void ChargerBonCommandeDansLivraison(int numeroBc)
        {
            var bonCommande = _context.BonCommandes
                .Include(b => b.LigneBonCommandes)
                .Include(b => b.CodeClientNavigation)
                .FirstOrDefault(b => b.NumeroBc == numeroBc);

            if (bonCommande == null)
            {
                XtraMessageBox.Show("Bon de commande introuvable.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mettre à jour le bon de livraison avec les infos du BC
            CurrentBonLivraison.NumeroBc = bonCommande.NumeroBc;
            CurrentBonLivraison.CodeClient = bonCommande.CodeClient;
            CurrentBonLivraison.NomClient = bonCommande.NomClient;

            // Mettre à jour les champs affichés (si bindés)
            RaisePropertyChanged(nameof(CurrentBonLivraison));

            // Supprimer les lignes existantes du bon de livraison actuel
            LignesBonLivraison.Clear();
            CurrentBonLivraison.LigneBonLivraisonFactures.Clear();

            // Copier les lignes du bon de commande
            foreach (var ligneBC in bonCommande.LigneBonCommandes)
            {
                var ligneLivraison = new LigneBonLivraisonFacture
                {
                    CodeArticle = ligneBC.CodeArticle,
                    Designation = ligneBC.Designation,
                    Quantite = ligneBC.Quantite,
                    PrixUnitaire = ligneBC.PrixUnitaire ,
                    Total = (ligneBC.Quantite * (ligneBC.PrixUnitaire)),
                    NumeroBlf = CurrentBonLivraison.NumeroBlf
                };

                LignesBonLivraison.Add(ligneLivraison);
                CurrentBonLivraison.LigneBonLivraisonFactures.Add(ligneLivraison);
            }

            CalculerTotal();
        }

        public bool VerifierEtEnregistrer()
        {
            var articlesAvecProblème = new List<FicheArticle>();

            foreach (var ligne in LignesBonLivraison)
            {
                var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == ligne.CodeArticle);
                if (article != null && ligne.Quantite > article.QuantiteEnStock)
                {
                    articlesAvecProblème.Add(article);
                }
            }

            if (articlesAvecProblème.Count > 0)
            {
                var noms = string.Join(", ", articlesAvecProblème.Select(a => a.Designation));
                var message = $"Les quantités demandées pour les articles suivants sont supérieures au stock :\n\n" +
                              $"{noms}\n\nVoulez-vous quand même continuer ?";

                var result = XtraMessageBox.Show(message, "Avertissement",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return false; // L'utilisateur a cliqué sur Non
                }
            }

            // Si tout est OK ou l'utilisateur veut continuer
            EnregistrerCommand.Execute(null);
            return EnregistrementReussi;
        }


    }
}