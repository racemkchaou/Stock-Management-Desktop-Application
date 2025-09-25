using DevExpress.XtraEditors;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Liste_Fournisseurs_View : DevExpress.XtraEditors.XtraForm
    {
        private readonly ListeFournisseursViewModel _viewModel;
        public Liste_Fournisseurs_View()
        {
            InitializeComponent();
            _viewModel = new ListeFournisseursViewModel();
            ficheFournisseurBindingSource.DataSource = _viewModel.Fournisseurs;

            // Ajouter le menu contextuel
            gridView1.PopupMenuShowing += GridView1_PopupMenuShowing;
        }

        private void GridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                DevExpress.XtraGrid.Menu.GridViewMenu menu = new DevExpress.XtraGrid.Menu.GridViewMenu((DevExpress.XtraGrid.Views.Grid.GridView)sender);
                menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Visualiser et modifier", OnVisualiserModifierClick));
                e.Menu = menu;
            }
        }

        private void OnVisualiserModifierClick(object sender, EventArgs e)
        {
            var selectedFournisseur = gridView1.GetFocusedRow() as FicheFournisseur;
            if (selectedFournisseur != null)
            {
                var mouvementView = new Mouvement_Fournisseur_View(selectedFournisseur);
                mouvementView.ShowDialog();
            }
        }
    }
}