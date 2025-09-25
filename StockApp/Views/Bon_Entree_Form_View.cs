using DevExpress.XtraEditors;
using StockApp.ViewModels;
using StockApp.Data;
using System;
using System.Windows.Forms;
using System.Linq;
using StockApp.Models;
using System.Drawing;

namespace StockApp.Views
{
    public partial class Bon_Entree_Form_View : XtraForm
    {
        private BonEntreeViewModel _viewModel;
        private ContextMenuStrip _gridContextMenu;
        private readonly decimal _ancienMontant;


        public Bon_Entree_Form_View(BonEntreeViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;


            // Calculer l'ancien montant dès le chargement
            _ancienMontant = _viewModel.BonEntree.NumeroBe > 0
                ? _viewModel.BonEntree.MontantTotal ?? 0
                : 0;

            // Configurer le binding des données
            DE_DateBE.DataBindings.Add("EditValue", _viewModel.BonEntree, "DateBe");
            DE_DateLivraison.DataBindings.Add(
                new Binding("EditValue", _viewModel.BonEntree, "DateLivraison", true,
                DataSourceUpdateMode.OnPropertyChanged)
                {
                    FormatString = "d",
                    FormattingEnabled = true,
                    NullValue = null
                });
            textEdit2.DataBindings.Add("EditValue", _viewModel.BonEntree, "MontantTotal", true,
                DataSourceUpdateMode.OnPropertyChanged, 0m, "n2");



            LUE_CodeFournisseur.DataBindings.Add("EditValue", _viewModel.BonEntree, "CodeFournisseur");
            TE_NomFournisseur.DataBindings.Add("EditValue", _viewModel.BonEntree, "NomFournisseur");

            // Configurer la grid
            gridControl1.DataSource = _viewModel.LignesBonEntree;
            // Charger les fournisseurs
            _viewModel.ChargerFournisseurs();

            // Lier la liste au LookUpEdit
            LUE_CodeFournisseur.Properties.DataSource = _viewModel.Fournisseurs;
            LUE_CodeFournisseur.Properties.DisplayMember = "CodeFournisseur";
            LUE_CodeFournisseur.Properties.ValueMember = "CodeFournisseur";
            LUE_CodeFournisseur.Properties.NullText = "Sélectionner un fournisseur ... ";

            var view = LUE_CodeFournisseur.Properties.View;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.Columns.Clear();

            view.Columns.AddVisible("CodeFournisseur", "Code");
            view.Columns.AddVisible("NomFournisseur", "Nom");
            view.Columns.AddVisible("Adresse", "Adresse");
            view.Columns.AddVisible("Tel", "Téléphone");


            // Événement pour mise à jour du nom
            LUE_CodeFournisseur.EditValueChanged += LUE_CodeFournisseur_EditValueChanged;


            textEdit2.Properties.ReadOnly = true;
            textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit2.Properties.DisplayFormat.FormatString = "n2";
            textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            textEdit2.Properties.Mask.EditMask = "n2";
            textEdit2.Properties.Mask.UseMaskAsDisplayFormat = true;


            // Ajouter le menu contextuel
            CreateGridContextMenu();
            gridView1.MouseDown += GridView1_MouseDown;


        }

        private void LUE_CodeFournisseur_EditValueChanged(object sender, EventArgs e)
        {
            var selectedCode = LUE_CodeFournisseur.EditValue?.ToString();
            var nomFournisseur = _viewModel.GetNomFournisseurByCode(selectedCode);

            // Mettre à jour à la fois l'UI et le modèle
            TE_NomFournisseur.Text = nomFournisseur;
            _viewModel.BonEntree.NomFournisseur = nomFournisseur;
        }

        private void BT_AjouterLigneBE_Click(object sender, EventArgs e)
        {
            var dateLivraison = DE_DateLivraison.EditValue;
            var form = new Ajouter_Ligne_Bon_Entree_View();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _viewModel.AjouterLigne(form.LigneBonEntree);
                textEdit2.EditValue = _viewModel.BonEntree.MontantTotal;

                DE_DateLivraison.EditValue = dateLivraison;
            }
        }

        private void BT_EnregistrerBE_Click(object sender, EventArgs e)
        {
            // Valider visuellement les champs obligatoires
            if (LUE_CodeFournisseur.EditValue == null)
            {
                LUE_CodeFournisseur.Properties.Appearance.BorderColor = Color.Red;
                XtraMessageBox.Show("Veuillez sélectionner un fournisseur avant d'enregistrer.",
                                  "Fournisseur manquant",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                return;
            }

            // Appeler la méthode d'enregistrement du ViewModel
            bool enregistrementReussi = _viewModel.EnregistrerBonEntree(_ancienMontant);

            // Fermer le formulaire seulement si l'enregistrement a réussi
            if (enregistrementReussi)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            // Sinon, le formulaire reste ouvert pour corrections
        }
        private void BT_ImprimerBE_Click(object sender, EventArgs e)
        {
            // Validation avant impression
            if (_viewModel.LignesBonEntree.Count == 0)
            {
                XtraMessageBox.Show("Aucune ligne à imprimer.",
                                  "Information",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                return;
            }

            _viewModel.ImprimerBonEntree();
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void CreateGridContextMenu()
        {
            _gridContextMenu = new ContextMenuStrip();

            var modifierItem = new ToolStripMenuItem("Modifier");
            modifierItem.Click += ModifierItem_Click;
            _gridContextMenu.Items.Add(modifierItem);

            var supprimerItem = new ToolStripMenuItem("Supprimer");
            supprimerItem.Click += SupprimerItem_Click;
            _gridContextMenu.Items.Add(supprimerItem);
        }

        private void GridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitInfo = gridView1.CalcHitInfo(e.Location);
                if (hitInfo.InRow)
                {
                    gridView1.FocusedRowHandle = hitInfo.RowHandle;
                    _gridContextMenu.Show(gridControl1, e.Location);
                }
            }
        }

        private void ModifierItem_Click(object sender, EventArgs e)
        {
            var ligneSelectionnee = (LigneBonEntree)gridView1.GetFocusedRow();
            if (ligneSelectionnee != null)
            {
                var form = new Ajouter_Ligne_Bon_Entree_View(ligneSelectionnee);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.ModifierLigne(ligneSelectionnee, form.LigneBonEntree);
                    textEdit2.EditValue = _viewModel.BonEntree.MontantTotal;
                }
            }
        }

        private void SupprimerItem_Click(object sender, EventArgs e)
        {
            var ligneSelectionnee = (LigneBonEntree)gridView1.GetFocusedRow();
            if (ligneSelectionnee != null)
            {
                if (XtraMessageBox.Show("Voulez-vous vraiment supprimer cette ligne?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _viewModel.SupprimerLigne(ligneSelectionnee);
                    textEdit2.EditValue = _viewModel.BonEntree.MontantTotal;
                }
            }
        }
    }
}