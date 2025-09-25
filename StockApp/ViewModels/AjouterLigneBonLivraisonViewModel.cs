using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using StockApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using StockApp.Data;

namespace StockApp.ViewModels
{
    public class AjouterLigneBonLivraisonViewModel : ViewModelBase
    {
        private AppDbContext _context;

        public LigneBonLivraisonFacture NouvelleLigne { get; set; }
        public ObservableCollection<FicheArticle> Articles { get; set; }

        public ICommand AjouterCommand { get; }
        public ICommand AnnulerCommand { get; }

        public AjouterLigneBonLivraisonViewModel()
        {
            _context = new AppDbContext();

            NouvelleLigne = new LigneBonLivraisonFacture();
            Articles = new ObservableCollection<FicheArticle>(_context.FicheArticles.ToList());

            AjouterCommand = new DelegateCommand(Ajouter);
            AnnulerCommand = new DelegateCommand(Annuler);
        }

        public bool? LigneValidee { get; private set; }

        private void Ajouter()
        {
            // Vérification plus complète
            if (NouvelleLigne.CodeArticleNavigation == null ||
                string.IsNullOrEmpty(NouvelleLigne.CodeArticle.ToString()) ||
                NouvelleLigne.Quantite <= 0)
            {
                XtraMessageBox.Show("Veuillez sélectionner un article et une quantité valide",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Vérification du stock
                if (NouvelleLigne.Quantite > NouvelleLigne.CodeArticleNavigation.QuantiteEnStock)
                {
                    string message = $"Stock insuffisant!\n\n" +
                                   $"Quantité demandée: {NouvelleLigne.Quantite}\n" +
                                   $"Stock disponible: {NouvelleLigne.CodeArticleNavigation.QuantiteEnStock}\n\n" +
                                   $"Voulez-vous quand même continuer?";

                    var result = XtraMessageBox.Show(message, "Avertissement",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        // Retourner false sans fermer la fenêtre
                        LigneValidee = false;
                        return;
                    }
                }

                // Calcul des valeurs si validation OK
                NouvelleLigne.PrixUnitaire = NouvelleLigne.CodeArticleNavigation.PrixUnitaireTtc * 1.1m;
                NouvelleLigne.Total = NouvelleLigne.Quantite * NouvelleLigne.PrixUnitaire;

                LigneValidee = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LigneValidee = false;
            }
        }
        private void Annuler()
        {
            LigneValidee = false;
        }

        public void InitialiserAvecLigne(LigneBonLivraisonFacture ligne)
        {
            if (ligne == null) return;

            // Trouver l'article correspondant dans la collection
            var article = Articles.FirstOrDefault(a => a.CodeArticle == ligne.CodeArticle);

            // Créer une nouvelle instance avec toutes les propriétés nécessaires
            NouvelleLigne = new LigneBonLivraisonFacture
            {
                CodeArticle = ligne.CodeArticle,
                Designation = ligne.Designation,
                Quantite = ligne.Quantite,
                PrixUnitaire = ligne.PrixUnitaire,
                Total = ligne.Total,
                CodeArticleNavigation = article // Ceci est crucial pour la validation
            };
        }
    }
}