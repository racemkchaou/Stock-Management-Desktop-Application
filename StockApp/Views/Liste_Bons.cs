using DevExpress.XtraEditors;
using StockApp.Data;
using StockApp.ViewModels;
using System;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Liste_Bons : XtraForm
    {
        private readonly ListeBonsViewModel _viewModel;
        private ContextMenuStrip _contextMenu;

        public Liste_Bons()
        {
            InitializeComponent();
            _viewModel = new ListeBonsViewModel();
            InitialiserControles();
            InitialiserGrid();
            InitialiserMenuContextuel();
            AbonnerEvenements();
            RafraichirGrid();
            
        }

        private void InitialiserMenuContextuel()
        {
            _contextMenu = new ContextMenuStrip();

            var menuModifier = new ToolStripMenuItem("Modifier");
            menuModifier.Click += (s, e) => OuvrirBonPourModification();
            _contextMenu.Items.Add(menuModifier);

            /*
            var menuSupprimer = new ToolStripMenuItem("Supprimer");
            menuSupprimer.Click += (s, e) => SupprimerBonSelectionne();
            _contextMenu.Items.Add(menuSupprimer);
            */

            gridView1.RowCellClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    _contextMenu.Show(gridControl1, e.Location);
                }
            };
        }

        private void OuvrirBonPourModification()
        {
            var bonSelectionne = gridView1.GetFocusedRow() as BonViewModel;
            if (bonSelectionne == null) return;

            string numeroBonModifie = bonSelectionne.Numero;
            string natureBonModifie = bonSelectionne.Nature;

            try
            {
                switch (bonSelectionne.Nature)
                {
                    case "Bon de commande":
                        var vmCommande = new BonCommandeViewModel();
                        try
                        {
                            vmCommande.ChargerBonCommande(int.Parse(bonSelectionne.Numero));
                            var formCommande = new Bon_Commande_Form_View(vmCommande);
                            if (formCommande.ShowDialog() == DialogResult.OK)
                            {
                                RafraichirEtReselectionner(numeroBonModifie, natureBonModifie);
                            }
                        }
                        finally
                        {
                            // Si vos ViewModels implémentent IDisposable
                            (vmCommande as IDisposable)?.Dispose();
                        }
                        break;

                    case "Bon de livraison":
                        var vmLivraison = new BonLivraisonViewModel();
                        try
                        {
                            vmLivraison.ChargerBonLivraison(int.Parse(bonSelectionne.Numero));
                            var formLivraison = new Bon_Livraison_Form_View(vmLivraison);
                            if (formLivraison.ShowDialog() == DialogResult.OK)
                            {
                                RafraichirEtReselectionner(numeroBonModifie, natureBonModifie);
                            }
                        }
                        finally
                        {
                            (vmLivraison as IDisposable)?.Dispose();
                        }
                        break;

                    case "Bon d'entrée":
                        var vmEntree = new BonEntreeViewModel();
                        try
                        {
                            vmEntree.ChargerBonEntree(int.Parse(bonSelectionne.Numero));
                            var formEntree = new Bon_Entree_Form_View(vmEntree);
                            if (formEntree.ShowDialog() == DialogResult.OK)
                            {
                                RafraichirEtReselectionner(numeroBonModifie, natureBonModifie);
                            }
                        }
                        finally
                        {
                            (vmEntree as IDisposable)?.Dispose();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ouverture: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RafraichirEtReselectionner(string numeroBon, string natureBon)
        {
            // Forcer un rafraîchissement complet des données
            _viewModel.RafraichirDonnees();
            gridView1.RefreshData();

            // Resélectionner le bon modifié
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var bon = gridView1.GetRow(i) as BonViewModel;
                if (bon != null && bon.Numero == numeroBon && bon.Nature == natureBon)
                {
                    gridView1.FocusedRowHandle = i;
                    break;
                }
            }
        }        /*
        private void SupprimerBonSelectionne()
        {
            var bonSelectionne = gridView1.GetFocusedRow() as BonViewModel;
            if (bonSelectionne == null) return;

            if (MessageBox.Show($"Voulez-vous vraiment supprimer ce bon ({bonSelectionne.Nature} n°{bonSelectionne.Numero}) ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (var context = new AppDbContext())
                    {
                        switch (bonSelectionne.Nature)
                        {
                            case "Bon de commande":
                                var bc = context.BonCommandes.Find(int.Parse(bonSelectionne.Numero));
                                if (bc != null) context.BonCommandes.Remove(bc);
                                break;

                            case "Bon de livraison":
                                var bl = context.BonLivraisonFactures.Find(int.Parse(bonSelectionne.Numero));
                                if (bl != null) context.BonLivraisonFactures.Remove(bl);
                                break;

                            case "Bon d'entrée":
                                var be = context.BonEntrees.Find(int.Parse(bonSelectionne.Numero));
                                if (be != null) context.BonEntrees.Remove(be);
                                break;
                        }
                        context.SaveChanges();
                        _viewModel.ChargerBons(); // Rafraîchir la liste
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression: {ex.Message}", "Erreur",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }        
        }
        */

        private void InitialiserControles()
        {
            // Initialisation du ComboBox Nature
            CBE_NatureBon.Properties.Items.AddRange(_viewModel.NaturesBons);
            CBE_NatureBon.SelectedIndex = 0;

            // Initialisation des dates
            DE_DateDebut.EditValue = _viewModel.DateDebut;
            DE_DateFin.EditValue = _viewModel.DateFin;
        }

        private void InitialiserGrid()
        {
            gridView1.Columns.Clear();

            // Colonne Numéro
            gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "Numero",
                Caption = "Numéro Bon",
                Visible = true,
                Width = 100
            });

            // Colonne Date
            gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "Date",
                Caption = "Date Bon",
                Visible = true,
                DisplayFormat = {
                    FormatType = DevExpress.Utils.FormatType.DateTime,
                    FormatString = "dd/MM/yyyy"
                },
                Width = 100
            });

            // Colonne Nom/Prenom
            gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "NomPrenom",
                Caption = "Nom et prénom",
                Visible = true,
                Width = 200
            });

            // Colonne Montant
            gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "MontantTotal",
                Caption = "Montant Total",
                Visible = true,
                DisplayFormat = {
                    FormatType = DevExpress.Utils.FormatType.Numeric,
                    FormatString = "N2"
                },
                Width = 100
            });

            // Colonne Nature
            gridView1.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn()
            {
                FieldName = "Nature",
                Caption = "Nature du bon",
                Visible = true,
                Width = 120
            });
        }

        private void AbonnerEvenements()
        {
            // Nature du bon
            CBE_NatureBon.EditValueChanged += (s, e) =>
            {
                _viewModel.NatureBonSelectionnee = CBE_NatureBon.Text;
            };

            // Dates
            DE_DateDebut.EditValueChanged += (s, e) =>
            {
                if (DE_DateDebut.EditValue != null)
                    _viewModel.DateDebut = (DateTime)DE_DateDebut.EditValue;
            };

            DE_DateFin.EditValueChanged += (s, e) =>
            {
                if (DE_DateFin.EditValue != null)
                    _viewModel.DateFin = (DateTime)DE_DateFin.EditValue;
            };

            // Numéro de bon
            TE_NumeroBon.EditValueChanged += (s, e) =>
            {
                _viewModel.NumeroBon = TE_NumeroBon.Text;
            };

            // Nom/Prénom
            TE_NomPrenom.EditValueChanged += (s, e) =>
            {
                _viewModel.NomPrenom = TE_NomPrenom.Text;
            };

            // Abonnement aux changements du ViewModel
            _viewModel.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(_viewModel.Bons))
                {
                    RafraichirGrid();
                }
            };
        }

        private void RafraichirGrid()
        {
            gridControl1.DataSource = _viewModel.Bons;
            gridView1.BestFitColumns();
        }

        private void Liste_Bons_Load(object sender, EventArgs e)
        {
            RafraichirGrid();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}