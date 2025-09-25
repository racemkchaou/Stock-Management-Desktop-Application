using DevExpress.XtraEditors;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Ajouter_Ligne_Bon_Commande_View : XtraForm
    {
        private AjouterLigneBonCommandeViewModel _viewModel;
        public LigneBonCommande NouvelleLigne { get; private set; }

        public Ajouter_Ligne_Bon_Commande_View(AjouterLigneBonCommandeViewModel viewModel, LigneBonCommande ligneExistante = null)
        {
            InitializeComponent();
            _viewModel = viewModel;
            InitializeBindings();

            // Si une ligne existante est passée, remplir les champs
            if (ligneExistante != null)
            {
                LUE_CodeArticle.EditValue = ligneExistante.CodeArticle;
                TE_Designation.Text = ligneExistante.Designation;
                TE_Quantite.Text = ligneExistante.Quantite.ToString();
                TE_PrixUnitaire.Text = ligneExistante.PrixUnitaire.ToString("N2");
            }

            // Gestion des événements
            LUE_CodeArticle.EditValueChanged += (s, e) =>
            {
                if (LUE_CodeArticle.EditValue != null)
                {
                    var article = LUE_CodeArticle.GetSelectedDataRow() as FicheArticle;
                    if (article != null)
                    {
                        TE_Designation.Text = article.Designation;
                        TE_PrixUnitaire.Text = (article.PrixUnitaireTtc * 1.10m).ToString("N2");
                    }
                }
            };           
        }

        private void InitializeBindings()
        {
            LUE_CodeArticle.Properties.DataSource = _viewModel.Articles;
            LUE_CodeArticle.Properties.DisplayMember = "CodeArticle";
            LUE_CodeArticle.Properties.ValueMember = "CodeArticle";

            var view = LUE_CodeArticle.Properties.View;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;

            view.Columns.Clear();

            view.Columns.AddVisible("CodeArticle", "Code");
            view.Columns.AddVisible("Designation", "Désignation");
            view.Columns.AddVisible("QuantiteEnStock", "Stock");
            view.Columns.AddVisible("PrixUnitaireTtc", "Prix TTC");

        }
        private void LUE_CodeArticle_EditValueChanged(object sender, EventArgs e)
        {
            if (LUE_CodeArticle.EditValue != null)
            {
                int codeArticle = (int)LUE_CodeArticle.EditValue;
                _viewModel.LoadArticleInfo(codeArticle, out string designation, out decimal prixUnitaire);

                TE_Designation.Text = designation;
                TE_PrixUnitaire.Text = prixUnitaire.ToString("N2");
            }
        }

        private void BT_AjouterLigneBonCommande_Click(object sender, EventArgs e)
        {
            if (LUE_CodeArticle.EditValue == null || string.IsNullOrEmpty(TE_Quantite.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codeArticle = (int)LUE_CodeArticle.EditValue;
            int quantite = int.Parse(TE_Quantite.Text);

            bool continuer;
            NouvelleLigne = _viewModel.CreerLigneAvecValidationStock(codeArticle, quantite, out continuer);

            if (!continuer || NouvelleLigne == null)
            {
                // L'utilisateur a cliqué sur NON → on reste sur la vue pour corriger
                return;
            }

            // OK → fermeture de la fenêtre
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}