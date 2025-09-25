using DevExpress.Dialogs.Core.View;
using DevExpress.XtraEditors;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Ajouter_Ligne_Bon_Livraison_View : DevExpress.XtraEditors.XtraForm
    {
        public AjouterLigneBonLivraisonViewModel _viewModel;

        public Ajouter_Ligne_Bon_Livraison_View(ObservableCollection<FicheArticle> articles, LigneBonLivraisonFacture ligneExistante = null)
        {
            InitializeComponent();

            _viewModel = new AjouterLigneBonLivraisonViewModel();
            this.DataContext = _viewModel;

            // Initialiser avec la ligne existante si elle est fournie
            if (ligneExistante != null)
            {
                _viewModel.InitialiserAvecLigne(ligneExistante);
            }

            // Liaison des données
            LUE_CodeArticle.Properties.DataSource = _viewModel.Articles;
            LUE_CodeArticle.Properties.DisplayMember = "CodeArticle";
            LUE_CodeArticle.Properties.ValueMember = "CodeArticle";
            LUE_CodeArticle.DataBindings.Add("EditValue", _viewModel.NouvelleLigne, "CodeArticle");

            // Liaison des propriétés
            TE_Designation.DataBindings.Add("EditValue", _viewModel.NouvelleLigne, "Designation");
            TE_Quantite.DataBindings.Add("EditValue", _viewModel.NouvelleLigne, "Quantite");
            TE_Prix.DataBindings.Add("EditValue", _viewModel.NouvelleLigne, "PrixUnitaire");

            var view = LUE_CodeArticle.Properties.View;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;

            view.Columns.Clear();

            view.Columns.AddVisible("CodeArticle", "Code");
            view.Columns.AddVisible("Designation", "Désignation");
            view.Columns.AddVisible("QuantiteEnStock", "Stock");
            view.Columns.AddVisible("PrixUnitaireTtc", "Prix TTC");

            // Gestion des événements
            LUE_CodeArticle.EditValueChanged += (s, e) =>
            {
                var article = LUE_CodeArticle.GetSelectedDataRow() as FicheArticle;
                if (article != null)
                {
                    _viewModel.NouvelleLigne.CodeArticle = article.CodeArticle;
                    _viewModel.NouvelleLigne.CodeArticleNavigation = article; // Important
                    _viewModel.NouvelleLigne.Designation = article.Designation;
                    _viewModel.NouvelleLigne.PrixUnitaire = article.PrixUnitaireTtc * 1.1m;

                    TE_Designation.Text = article.Designation;
                    TE_Prix.Text = (article.PrixUnitaireTtc * 1.1m).ToString("N2");
                }
            };
        }



        private void BT_AjouterLigneBonLivraison_Click(object sender, EventArgs e)
        {
            _viewModel.AjouterCommand.Execute(null);
            // Seulement fermer si la ligne a été validée (LigneValidee = true)
            if (_viewModel.LigneValidee == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
