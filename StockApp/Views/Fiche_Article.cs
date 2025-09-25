using DevExpress.XtraEditors;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Fiche_Article : DevExpress.XtraEditors.XtraForm
    {
        private readonly FicheArticleViewModel _viewModel;
        private FicheArticle _articleOriginal;
        private bool _isEditMode;

        public Fiche_Article()
        {
            InitializeComponent();
            _viewModel = new FicheArticleViewModel();
            ConfigurerControles();
        }

        public void SetArticle(FicheArticle article)
        {
            _articleOriginal = article;
            _isEditMode = true;
            _viewModel.LoadArticle(article);

            // Remplir les champs
            TE_CodeArticle.Text = article.CodeArticle.ToString();
            TE_Designation.Text = article.Designation;
            TE_PrixHT.Text = article.PrixUnitaireHorsTaxes.ToString("N2");
            TE_TVA.Text = article.TauxDeTva.ToString("N2");
            TE_Quantite.Text = article.QuantiteEnStock.ToString();

            // En mode modification
            TE_CodeArticle.Properties.ReadOnly = true;
            TE_Quantite.Properties.ReadOnly = true; // Bloque la modification de la quantité
            BT_AjouterFicheArticle.Text = "Modifier";
        }

        public FicheArticle GetArticleModifie()
        {
            return new FicheArticle
            {
                CodeArticle = _articleOriginal.CodeArticle,
                Designation = TE_Designation.Text,
                PrixUnitaireHorsTaxes = decimal.Parse(TE_PrixHT.Text),
                TauxDeTva = double.Parse(TE_TVA.Text),
                QuantiteEnStock = int.Parse(TE_Quantite.Text),
                PrixUnitaireTtc = decimal.Parse(TE_PrixHT.Text) * (1 + (decimal)(double.Parse(TE_TVA.Text) / 100))
            };
        }

        private void ConfigurerControles()
        {
            // Votre configuration existante des contrôles...
        }

        private void BT_AjouterFicheArticle_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps()) return;

            // Injection des valeurs depuis les TextBox vers le ViewModel
            _viewModel.CodeArticle = int.Parse(TE_CodeArticle.Text);
            _viewModel.Designation = TE_Designation.Text;
            _viewModel.PrixUnitaireHT = decimal.Parse(TE_PrixHT.Text);
            _viewModel.TauxTVA = double.Parse(TE_TVA.Text);
            _viewModel.Quantite = int.Parse(TE_Quantite.Text);

            if (_isEditMode)
            {
                if (_viewModel.ModifierArticle())
                {
                    MessageBox.Show("L'article a été modifié avec succès !", "Succès",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                if (_viewModel.AjouterArticle())
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
        private bool ValiderChamps()
        {
            if (!int.TryParse(TE_CodeArticle.Text, out int codeArticle))
            {
                MessageBox.Show("Code article invalide");
                return false;
            }

            if (string.IsNullOrWhiteSpace(TE_Designation.Text))
            {
                MessageBox.Show("La désignation est obligatoire");
                return false;
            }

            if (!decimal.TryParse(TE_PrixHT.Text, out decimal prixHT) || prixHT <= 0)
            {
                MessageBox.Show("Prix HT invalide");
                return false;
            }

            if (!double.TryParse(TE_TVA.Text, out double tva) || tva < 0)
            {
                MessageBox.Show("Taux TVA invalide");
                return false;
            }

            if (!int.TryParse(TE_Quantite.Text, out int quantite) || quantite < 0)
            {
                MessageBox.Show("Quantité invalide");
                return false;
            }

            return true;
        }

        private void Prix_unitaire_HT_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}