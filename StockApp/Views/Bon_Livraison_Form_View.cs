using DevExpress.XtraEditors;
using StockApp.Models;


using StockApp.ViewModels;
using System;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Bon_Livraison_Form_View : DevExpress.XtraEditors.XtraForm
    {
        private BonLivraisonViewModel _viewModel;

        public Bon_Livraison_Form_View(BonLivraisonViewModel viewModel)
        {
            InitializeComponent();

            _viewModel = viewModel;
            _viewModel.CalculerTotal();
            this.DataContext = _viewModel;

            // Liaison des données
            LUE_CodeClient.Properties.DataSource = _viewModel.Clients;
            LUE_CodeClient.Properties.DisplayMember = "CodeClient";
            LUE_CodeClient.Properties.ValueMember = "CodeClient";
            LUE_CodeClient.DataBindings.Add("EditValue", _viewModel.CurrentBonLivraison, "CodeClient");

            LUE_CodeClient.Properties.NullText = "Sélectionner un client ...";


            var view = LUE_CodeClient.Properties.View;
            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowGroupPanel = false;

            view.Columns.Clear();
            view.Columns.AddVisible("CodeClient", "Code");
            view.Columns.AddVisible("NomClient", "Nom");
            view.Columns.AddVisible("Adresse", "Adresse"); 
            view.Columns.AddVisible("Tel", "Téléphone");


            LUE_NumeroBC.Properties.DataSource = _viewModel.BonCommandes;
            LUE_NumeroBC.Properties.DisplayMember = "NumeroBc";
            LUE_NumeroBC.Properties.ValueMember = "NumeroBc";
            LUE_NumeroBC.DataBindings.Add("EditValue", _viewModel.CurrentBonLivraison, "NumeroBC");

            var bcView = LUE_NumeroBC.Properties.View;
            bcView.OptionsView.ShowAutoFilterRow = true;
            bcView.OptionsView.ShowGroupPanel = false;

            bcView.Columns.Clear();
            bcView.Columns.AddVisible("NumeroBc", "Numéro BC");
            bcView.Columns.AddVisible("DateBc", "Date");
            bcView.Columns.AddVisible("CodeClient", "Code Client");
            bcView.Columns.AddVisible("NomClient", "Nom Client");
            bcView.Columns.AddVisible("MontantTotal", "Total");



            gridControl1.DataSource = _viewModel.LignesBonLivraison;

            // Liaison des propriétés
            DE_DateBL.DataBindings.Add("EditValue", _viewModel.CurrentBonLivraison, "DateBlf");
            TE_Total.DataBindings.Add("EditValue", _viewModel, "DisplayTotal");
            TE_NomClient.DataBindings.Add("EditValue", _viewModel.CurrentBonLivraison, "NomClient");


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
                        _viewModel.CurrentBonLivraison.CodeClient = client.CodeClient;
                        _viewModel.CurrentBonLivraison.NomClient = client.NomClient;
                    }
                }
            };
            LUE_NumeroBC.EditValueChanged += (s, e) =>
            {
                var bc = LUE_NumeroBC.Properties.View.GetFocusedRow() as BonCommande;
                if (bc != null)
                {
                    _viewModel.CurrentBonLivraison.NumeroBc = bc.NumeroBc;
                    _viewModel.ChargerBonCommandeDansLivraison(bc.NumeroBc);
                    LUE_CodeClient.Text = _viewModel.CurrentBonLivraison.CodeClient.ToString();
                    TE_NomClient.Text = _viewModel.CurrentBonLivraison.NomClient;

                }
            };            // Configuration du contrôle TE_Total
            TE_Total.Properties.ReadOnly = true;
            TE_Total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            TE_Total.Properties.DisplayFormat.FormatString = "n2"; // 2 décimales
            TE_Total.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            TE_Total.Properties.Mask.EditMask = "n2";
            TE_Total.Properties.Mask.UseMaskAsDisplayFormat = true;

            var contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Modifier", null, ModifierLigne_Click);
            contextMenu.Items.Add("Supprimer", null, SupprimerLigne_Click);

            // Affecter le menu au GridView
            gridView1.GridControl.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    var hitInfo = gridView1.CalcHitInfo(gridView1.GridControl.PointToClient(Control.MousePosition));
                    if (hitInfo.InRow || hitInfo.InRowCell)
                    {
                        gridView1.FocusedRowHandle = hitInfo.RowHandle; // sélectionne la ligne
                        contextMenu.Show(Control.MousePosition);
                    }
                }
            };
        }

        private void BT_AjouterLigneBL_Click(object sender, EventArgs e)
        {
            using (var ajouterView = new Ajouter_Ligne_Bon_Livraison_View(_viewModel.Articles))
            {
                if (ajouterView.ShowDialog() == DialogResult.OK)
                {
                    // Créer une nouvelle instance pour éviter les conflits
                    var nouvelleLigne = new LigneBonLivraisonFacture
                    {
                        CodeArticle = ajouterView._viewModel.NouvelleLigne.CodeArticle,
                        Designation = ajouterView._viewModel.NouvelleLigne.Designation,
                        Quantite = ajouterView._viewModel.NouvelleLigne.Quantite,
                        PrixUnitaire = ajouterView._viewModel.NouvelleLigne.PrixUnitaire,
                        Total = ajouterView._viewModel.NouvelleLigne.Total
                    };

                    _viewModel.SetLigneToAdd(nouvelleLigne);
                    _viewModel.AjouterLigne();
                    gridView1.RefreshData();
                }
            }
        }
        private void BT_EnregistrerBL_Click(object sender, EventArgs e)
        {
            // Validation 1: Vérifier qu'un client est sélectionné
            if (_viewModel.CurrentBonLivraison.CodeClient == 0 || string.IsNullOrEmpty(_viewModel.CurrentBonLivraison.NomClient))
            {
                XtraMessageBox.Show("Veuillez sélectionner un client avant d'enregistrer le bon de livraison.",
                                  "Client manquant",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                LUE_CodeClient.Focus();
                return;
            }

            // Validation 2: Vérifier qu'il y a au moins une ligne dans le bon
            if (_viewModel.LignesBonLivraison.Count == 0)
            {
                XtraMessageBox.Show("Veuillez ajouter au moins une ligne au bon de livraison avant d'enregistrer.",
                                  "Lignes manquantes",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                BT_AjouterLigneBL.Focus();
                return;
            }

            if (_viewModel.VerifierEtEnregistrer())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        private void BT_ImprimerBL_Click(object sender, EventArgs e)
        {
            _viewModel.ImprimerCommand.Execute(null);
        }

        private void ModifierLigne_Click(object sender, EventArgs e)
        {
            var ligneSelectionnee = gridView1.GetFocusedRow() as LigneBonLivraisonFacture;
            if (ligneSelectionnee == null) return;

            // Créer une copie "détachée" de la ligne
            var ligneCopie = new LigneBonLivraisonFacture
            {
                CodeArticle = ligneSelectionnee.CodeArticle,
                Designation = ligneSelectionnee.Designation,
                Quantite = ligneSelectionnee.Quantite,
                PrixUnitaire = ligneSelectionnee.PrixUnitaire,
                Total = ligneSelectionnee.Total
            };

            using (var formEdition = new Ajouter_Ligne_Bon_Livraison_View(_viewModel.Articles, ligneCopie))
            {
                if (formEdition.ShowDialog() == DialogResult.OK)
                {
                    // Créer une nouvelle instance complètement détachée
                    var nouvelleLigne = new LigneBonLivraisonFacture
                    {
                        CodeArticle = formEdition._viewModel.NouvelleLigne.CodeArticle,
                        Designation = formEdition._viewModel.NouvelleLigne.Designation,
                        Quantite = formEdition._viewModel.NouvelleLigne.Quantite,
                        PrixUnitaire = formEdition._viewModel.NouvelleLigne.PrixUnitaire,
                        Total = formEdition._viewModel.NouvelleLigne.Total
                    };

                    _viewModel.SetLigneToAdd(nouvelleLigne);
                    _viewModel.AjouterLigne();
                    gridView1.RefreshData();
                }
            }
        }
        private void SupprimerLigne_Click(object sender, EventArgs e)
        {
            var ligneSelectionnee = gridView1.GetFocusedRow() as LigneBonLivraisonFacture;
            if (ligneSelectionnee == null) return;

            var confirm = XtraMessageBox.Show("Voulez-vous vraiment supprimer cette ligne ?", "Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                _viewModel.SupprimerLigne(ligneSelectionnee);
                gridView1.RefreshData();
            }
        }
    }
}