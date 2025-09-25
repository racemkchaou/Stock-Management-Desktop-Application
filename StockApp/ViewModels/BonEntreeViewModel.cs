using StockApp.Data;
using StockApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using System;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.Drawing;
using StockApp.XtraReports;

namespace StockApp.ViewModels
{
    public class BonEntreeViewModel
    {
        private AppDbContext _context;
        public BonEntree BonEntree { get; set; }
        public ObservableCollection<LigneBonEntree> LignesBonEntree { get; set; }
        public ObservableCollection<FicheFournisseur> Fournisseurs { get; private set; }

        public DateTime? DateLivraisonDateTime
        {
            get => BonEntree.DateLivraison?.ToDateTime(TimeOnly.MinValue);
            set => BonEntree.DateLivraison = value.HasValue ?
                   DateOnly.FromDateTime(value.Value) : null;
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

        public void ChargerFournisseurs()
        {
            Fournisseurs = new ObservableCollection<FicheFournisseur>(_context.FicheFournisseurs.ToList());
        }

        public string GetNomFournisseurByCode(string code)
        {
            if (int.TryParse(code, out int codeInt))
            {
                var fournisseur = Fournisseurs?.FirstOrDefault(f => f.CodeFournisseur == codeInt);
                return fournisseur?.NomFournisseur ?? string.Empty;
            }
            return string.Empty;
        }



        public BonEntreeViewModel()
        {
            _context = new AppDbContext();
            BonEntree = new BonEntree
            {
                DateBe = DateOnly.FromDateTime(DateTime.Today),
                DateLivraison = DateOnly.FromDateTime(DateTime.Today)
            };
             LignesBonEntree = new ObservableCollection<LigneBonEntree>();
        }

        public void AjouterLigne(LigneBonEntree ligne)
        {
            var dateLivraison = BonEntree.DateLivraison;
            var ligneExistante = LignesBonEntree.FirstOrDefault(l => l.CodeArticle == ligne.CodeArticle);

            if (ligneExistante != null)
            {
                // 1. Supprimer l'ancienne ligne
                LignesBonEntree.Remove(ligneExistante);

                // 2. Ajouter la nouvelle ligne (qui remplace l'ancienne)
                LignesBonEntree.Add(ligne);
            }
            else
            {
                // Cas normal - article n'existe pas encore
                LignesBonEntree.Add(ligne);
            }
            // Mettre à jour le total
            BonEntree.MontantTotal = LignesBonEntree.Sum(l => l.Total);
            BonEntree.DateLivraison = dateLivraison;
        }



        public bool EnregistrerBonEntree(decimal ancienMontant)
        {
            // Validation du fournisseur et des lignes
            if (BonEntree.CodeFournisseur == 0 || string.IsNullOrWhiteSpace(BonEntree.NomFournisseur))
            {
                XtraMessageBox.Show("Vous devez choisir un fournisseur avant d'enregistrer le bon.",
                                  "Fournisseur manquant",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return false;
            }

            if (LignesBonEntree.Count == 0)
            {
                XtraMessageBox.Show("Vous devez ajouter au moins une ligne au bon d'entrée.",
                                  "Aucune ligne",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return false;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    bool isExisting = BonEntree.NumeroBe > 0;
                    var bonExistant = isExisting ?
                        _context.BonEntrees
                            .Include(b => b.LigneBonEntrees)
                            .FirstOrDefault(b => b.NumeroBe == BonEntree.NumeroBe) : null;

                    if (isExisting && bonExistant != null)
                    {

                        // 2. Annuler l'impact stock des anciennes lignes
                        foreach (var ancienneLigne in bonExistant.LigneBonEntrees.ToList())
                        {
                            if (ancienneLigne.CodeArticle.HasValue)
                            {
                                MettreAJourStockArticle(ancienneLigne.CodeArticle, -ancienneLigne.Quantite);
                            }
                            _context.LigneBonEntrees.Remove(ancienneLigne);
                        }

                        // 3. Mettre à jour les propriétés du bon existant
                        bonExistant.DateBe = BonEntree.DateBe;
                        bonExistant.DateLivraison = BonEntree.DateLivraison;
                        bonExistant.CodeFournisseur = BonEntree.CodeFournisseur;
                        bonExistant.NomFournisseur = BonEntree.NomFournisseur;
                    }
                    else
                    {
                        // Nouveau bon
                        _context.BonEntrees.Add(BonEntree);
                    }

                    // Synchroniser les articles avant d'ajouter les lignes
                    VerifierEtMettreAJourPrixEtTVA();

                    // Sauvegarde intermédiaire pour obtenir le NumeroBe
                    _context.SaveChanges();

                    // 4. Ajouter les nouvelles lignes
                    decimal nouveauTotal = 0;
                    foreach (var ligne in LignesBonEntree)
                    {
                        var nouvelleLigne = new LigneBonEntree
                        {
                            NumeroBe = BonEntree.NumeroBe,
                            CodeArticle = ligne.CodeArticle,
                            Designation = ligne.Designation,
                            Quantite = ligne.Quantite,
                            PrixUnitaireHT = ligne.PrixUnitaireHT,
                            PrixUnitaireTTC = ligne.PrixUnitaireTTC,
                            TauxTVA = ligne.TauxTVA,
                            Total = ligne.Total
                        };

                        _context.LigneBonEntrees.Add(nouvelleLigne);
                        nouveauTotal += ligne.Total??0;

                        if (ligne.CodeArticle.HasValue)
                        {
                            MettreAJourStockArticle(ligne.CodeArticle, ligne.Quantite);
                        }
                    }

                    // Mettre à jour le montant total du bon
                    BonEntree.MontantTotal = nouveauTotal;

                    // 5. Mettre à jour le total du fournisseur
                    var fournisseur = _context.FicheFournisseurs.Find(BonEntree.CodeFournisseur);
                    if (fournisseur != null)
                    {
                        // Calcul correct du nouveau total
                        fournisseur.TotalDesAchats = (fournisseur.TotalDesAchats ?? 0) - ancienMontant + nouveauTotal;

                        // Assurer que le total ne devient pas négatif
                        if (fournisseur.TotalDesAchats < 0)
                        {
                            fournisseur.TotalDesAchats = 0;
                        }
                    }

                    _context.SaveChanges();
                    transaction.Commit();

                   
                    XtraMessageBox.Show("Enregistrement réussi!", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    string errorMessage = "Erreur lors de l'enregistrement";

                    while (ex.InnerException != null)
                    {
                        ex = ex.InnerException;
                        errorMessage += $"\n→ {ex.Message}";
                    }

                    XtraMessageBox.Show(errorMessage, "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        private void MettreAJourStockArticle(int? codeArticle, int quantiteAjoutee)
        {
            if (!codeArticle.HasValue)
            {
                throw new ArgumentNullException(nameof(codeArticle), "Le code article ne peut pas être null");
            }

            var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == codeArticle.Value);
            if (article != null)
            {
                article.QuantiteEnStock += quantiteAjoutee;
                // Pas besoin de SaveChanges() ici - sera fait par la méthode appelante
            }
            else
            {
                throw new Exception($"Article avec code {codeArticle} non trouvé");
            }
        }

        public void ChargerBonEntree(int numeroBe)
        {
            var bon = _context.BonEntrees
                .Include(b => b.LigneBonEntrees)
                .FirstOrDefault(b => b.NumeroBe == numeroBe);

            if (bon != null)
            {
                BonEntree = bon;
                LignesBonEntree = new ObservableCollection<LigneBonEntree>(bon.LigneBonEntrees);
            }
        }

        public void SupprimerLigne(LigneBonEntree ligne)
        {
            if (ligne != null && LignesBonEntree.Contains(ligne))
            {
                LignesBonEntree.Remove(ligne);
                // Mettre à jour le total
                BonEntree.MontantTotal = LignesBonEntree.Sum(l => l.Total);
            }
        }

        public void ModifierLigne(LigneBonEntree ligneExistante, LigneBonEntree nouvelleLigne)
        {
            if (ligneExistante == null || nouvelleLigne == null)
                return;

            // Supprimer l'ancienne ligne
            LignesBonEntree.Remove(ligneExistante);

            // Ajouter la nouvelle ligne
            LignesBonEntree.Add(nouvelleLigne);

            // Mettre à jour le total
            BonEntree.MontantTotal = LignesBonEntree.Sum(l => l.Total);
        }

        public void ImprimerBonEntree()
        {
            if (BonEntree.NumeroBe <= 0)
            {
                XtraMessageBox.Show("Le bon d'entrée doit être enregistré avant d'être imprimé.",
                                  "Impression impossible",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            if (LignesBonEntree.Count == 0)
            {
                XtraMessageBox.Show("Aucune ligne à imprimer.",
                                  "Impression impossible",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var report = new BonEntreeReport(BonEntree, LignesBonEntree.ToList());
                var printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Erreur lors de l'impression: {ex.Message}",
                                  "Erreur",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            }
        }
        private void ShowWarning(string message)
        {
            XtraMessageBox.Show(message, "Impression impossible",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowError(string message)
        {
            XtraMessageBox.Show(message, "Erreur",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VerifierEtMettreAJourPrixEtTVA()
        {
            foreach (var ligne in LignesBonEntree)
            {
                if (!ligne.CodeArticle.HasValue)
                    continue;

                var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == ligne.CodeArticle.Value);
                if (article == null)
                    continue;

                bool modifié = false;

                // Pour PrixUnitaireHorsTaxes (decimal)
                if (article.PrixUnitaireHorsTaxes != ligne.PrixUnitaireHT)
                {
                    article.PrixUnitaireHorsTaxes = ligne.PrixUnitaireHT;
                    modifié = true;
                }

                // Pour TauxDeTva (double) - nécessite conversion si ligne.TauxTVA est decimal
                if (article.TauxDeTva != (double)ligne.TauxTVA)
                {
                    article.TauxDeTva = (double)ligne.TauxTVA;
                    modifié = true;
                }

                // Mise à jour automatique du PrixUnitaireTtc
                if (modifié)
                {
                    article.PrixUnitaireTtc = article.PrixUnitaireHorsTaxes * (1 + (decimal)(article.TauxDeTva / 100));
                }
            }
        }
    }
}