using DevExpress.XtraEditors;
using StockApp.ViewModels;
using StockApp.Models;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace StockApp.Views
{
    public partial class Bon_Commande_Form_View : XtraForm
    {
        private BonCommandeViewModel _viewModel;
        private ContextMenuStrip _gridContextMenu;

        public Bon_Commande_Form_View(BonCommandeViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            _viewModel.CalculerTotal();
            InitializeBindings();

            // Créer et configurer le menu contextuel
            CreateGridContextMenu();
            gridView1.MouseDown += GridView1_MouseDown;

            // Gestion des événements
            LUE_CodeClient.EditValueChanged += (s, e) =>
            {
                if (LUE_CodeClient.EditValue != null)
                {
                    var client = LUE_CodeClient.Properties.View.GetRow(
                        LUE_CodeClient.Properties.View.FocusedRowHandle) as FicheClient;

                    if (client != null)
                    {
                        TE_NomClient.Text = client.NomClient;
                        _viewModel.CurrentBonCommande.CodeClient = client.CodeClient;
                        _viewModel.CurrentBonCommande.NomClient = client.NomClient;
                    }
                }
            };
        }

        private void InitializeBindings()
        {
            // Liaison des données
            DE_DateBC.DataBindings.Add("EditValue", _viewModel.CurrentBonCommande, "DateBc");
            TE_NomClient.DataBindings.Add("EditValue", _viewModel.CurrentBonCommande, "NomClient");
            TE_Total.DataBindings.Add("EditValue", _viewModel, "DisplayTotal");
            DE_DateLivraison.DataBindings.Add("EditValue", _viewModel.CurrentBonCommande, "DateLivraison", true, DataSourceUpdateMode.OnPropertyChanged);

            
            // Configuration du GridControl
            gridControl1.DataSource = _viewModel.LignesCommande;

            LUE_CodeClient.Properties.NullText = "Sélectionner un client ...";


            // Configuration du contrôle TE_Total
            TE_Total.Properties.ReadOnly = true;
            TE_Total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            TE_Total.Properties.DisplayFormat.FormatString = "n2";
            TE_Total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            TE_Total.Properties.Mask.EditMask = "n2";
            TE_Total.Properties.Mask.UseMaskAsDisplayFormat = true;

            // Configuration du SearchLookUpEdit pour les clients
            LUE_CodeClient.Properties.DataSource = _viewModel.Clients;
            LUE_CodeClient.Properties.DisplayMember = "CodeClient";
            LUE_CodeClient.Properties.ValueMember = "CodeClient";
            LUE_CodeClient.DataBindings.Add("EditValue", _viewModel.CurrentBonCommande, "CodeClient");

            // Configuration de la vue
            var view = LUE_CodeClient.Properties.View;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;

            // Configuration des colonnes (si non déjà fait dans le Designer)
            view.Columns.Clear();
            view.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "CodeClient",
                Caption = "Code Client",
                Visible = true
            });
            view.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "NomClient",
                Caption = "Nom",
                Visible = true
            });
            view.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "Adresse",
                Caption = "Adresse",
                Visible = true
            });
            view.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "Tel",
                Caption = "Téléphone",
                Visible = true
            });
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
            var ligneSelectionnee = (LigneBonCommande)gridView1.GetFocusedRow();
            if (ligneSelectionnee != null)
            {
                var ajouterLigneVM = new AjouterLigneBonCommandeViewModel();
                var form = new Ajouter_Ligne_Bon_Commande_View(ajouterLigneVM, ligneSelectionnee);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _viewModel.ModifierLigne(ligneSelectionnee, form.NouvelleLigne);
                    _viewModel.CalculerTotal();
                }
            }
        }

        private void SupprimerItem_Click(object sender, EventArgs e)
        {
            var ligneSelectionnee = (LigneBonCommande)gridView1.GetFocusedRow();
            if (ligneSelectionnee != null)
            {
                if (XtraMessageBox.Show("Voulez-vous vraiment supprimer cette ligne?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _viewModel.SupprimerLigne(ligneSelectionnee);
                    _viewModel.CalculerTotal();
                }
            }
        }

        private void BT_AjouterLigneBC_Click(object sender, EventArgs e)
        {
            var ajouterLigneVM = new AjouterLigneBonCommandeViewModel();
            var form = new Ajouter_Ligne_Bon_Commande_View(ajouterLigneVM);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _viewModel.AjouterLigne(form.NouvelleLigne);
            }
        }

        private void BT_EnregistrerBC_Click(object sender, EventArgs e)
        {
            _viewModel.EnregistrerBonCommande();
            if (_viewModel.IsSavedSuccessfully)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BT_ImprimerBC_Click(object sender, EventArgs e)
        {
            _viewModel.ImprimerBonCommande();
        }
    }
}