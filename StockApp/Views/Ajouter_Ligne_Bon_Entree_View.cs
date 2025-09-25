using DevExpress.XtraEditors;
using StockApp.Data;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Ajouter_Ligne_Bon_Entree_View : XtraForm
    {
        public LigneBonEntree LigneBonEntree { get; private set; }
        private AjouterLigneBonEntreeViewModel _viewModel;
        public decimal TauxTVA { get; set; }

        public Ajouter_Ligne_Bon_Entree_View(LigneBonEntree ligneExistante = null)
        {
            InitializeComponent();
            _viewModel = new AjouterLigneBonEntreeViewModel();
            ConfigurerLookUpArticles();
            ConfigurerEvenements();

            if (ligneExistante != null)
            {
                ChargerLigneExistante(ligneExistante);
            }
        }

        private void ChargerLigneExistante(LigneBonEntree ligne)
        {
            LUE_CodeArticle.EditValue = ligne.CodeArticle;
            TE_Designation.Text = ligne.Designation;
            TE_Quantite.Text = ligne.Quantite.ToString();
            TE_PrixUnitaireHT.Text = ligne.PrixUnitaireHT.ToString("N3");
            TE_TVA.Text = ligne.TauxTVA.ToString("N2");

            // Désactiver la modification du code article pour une ligne existante
            LUE_CodeArticle.Properties.ReadOnly = true;
        }
        private void ConfigurerLookUpArticles()
        {
            using (var context = new AppDbContext())
            {
                var articles = context.FicheArticles.ToList();
                LUE_CodeArticle.Properties.DataSource = articles;
                LUE_CodeArticle.Properties.DisplayMember = "CodeArticle";
                LUE_CodeArticle.Properties.ValueMember = "CodeArticle";

                var view = LUE_CodeArticle.Properties.View;
                view.OptionsView.ShowAutoFilterRow = true;
                view.OptionsView.ShowGroupPanel = false;
                view.Columns.Clear(); // Nettoyer avant d’ajouter

                // Ajouter les colonnes manuellement :
                view.Columns.AddVisible("CodeArticle", "Code Article");
                view.Columns.AddVisible("Designation", "Désignation");
                view.Columns.AddVisible("PrixUnitaireHorsTaxes", "Prix HT");
                view.Columns.AddVisible("TauxDeTva", "TVA");
                view.Columns.AddVisible("QuantiteEnStock", "Stock");
            }
        }
        private void ConfigurerEvenements()
        {
            // Lorsque l'article est sélectionné, remplir automatiquement la désignation
            LUE_CodeArticle.EditValueChanged += (s, e) =>
            {
                if (LUE_CodeArticle.EditValue != null)
                {
                    var article = LUE_CodeArticle.Properties.View.GetRow(
                        LUE_CodeArticle.Properties.View.FocusedRowHandle) as FicheArticle;

                    if (article != null)
                    {
                        TE_Designation.Text = article.Designation;
                        var (prixHT, tauxTVA) = _viewModel.GetArticleInfos(article.CodeArticle.ToString());
                        TE_PrixUnitaireHT.Text = prixHT.ToString("N3");
                        TE_TVA.Text = tauxTVA.ToString("N2");
                    }
                }
            };
        }



        private void CalculerPrixTTC()
        {
            if (decimal.TryParse(TE_PrixUnitaireHT.Text, out decimal prixHT) &&
                decimal.TryParse(TE_TVA.Text, out decimal tauxTVA))
            {
                decimal prixTTC = prixHT * (1 + tauxTVA / 100);
                // TE_PrixUnitaireTTC.Text = prixTTC.ToString("N3");
            }
        }

        private void BT_AjoutLigneBE_Click(object sender, EventArgs e)
        {
            // Validation des champs (identique à avant)
            if (string.IsNullOrEmpty(LUE_CodeArticle.EditValue?.ToString()))
            {
                XtraMessageBox.Show("Veuillez sélectionner un article", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(TE_Quantite.Text, out int quantite) || quantite <= 0)
            {
                XtraMessageBox.Show("Quantité invalide", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(TE_PrixUnitaireHT.Text, out decimal prixUnitaireHT) || prixUnitaireHT <= 0)
            {
                XtraMessageBox.Show("Prix unitaire HT invalide", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(TE_TVA.Text, out decimal tauxTVA) || tauxTVA < 0)
            {
                XtraMessageBox.Show("Taux de TVA invalide", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LigneBonEntree != null) // Mode modification
            {
                LigneBonEntree = _viewModel.ModifierLigne(
                    LigneBonEntree,
                    LUE_CodeArticle.EditValue.ToString(),
                    TE_Designation.Text,
                    quantite,
                    prixUnitaireHT,
                    tauxTVA);
            }
            else // Mode ajout
            {
                LigneBonEntree = _viewModel.AjouterLigne(
                    LUE_CodeArticle.EditValue.ToString(),
                    TE_Designation.Text,
                    quantite,
                    prixUnitaireHT,
                    tauxTVA);
            }

            if (LigneBonEntree != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}