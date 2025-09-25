using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using StockApp.ViewModels;
using System;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Liste_Clients_View : DevExpress.XtraEditors.XtraForm
    {
        private readonly ListeClientsViewModel _viewModel;
        private GridView _gridView;

        public Liste_Clients_View()
        {
            InitializeComponent();

            _viewModel = new ListeClientsViewModel();
            ficheClientBindingSource.DataSource = _viewModel.Clients;

            _gridView = gridControl1.MainView as GridView;
            ConfigureContextMenu();
        }

        private void ConfigureContextMenu()
        {
            _gridView.PopupMenuShowing += GridView_PopupMenuShowing;
        }

        private void GridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                if (e.Menu == null)
                    return;

                var visualiserItem = new DevExpress.Utils.Menu.DXMenuItem("Visualiser et modifier mon client", (s, args) => VisualiserModifierClient());
                //var supprimerItem = new DevExpress.Utils.Menu.DXMenuItem("Supprimer client", (s, args) => SupprimerClient());

                e.Menu.Items.Add(visualiserItem);
                //e.Menu.Items.Add(supprimerItem);

            }
        }

        private void VisualiserModifierClient()
        {
            var selectedClient = _gridView.GetFocusedRow() as Models.FicheClient;
            if (selectedClient != null)
            {
                var mouvementClientView = new Mouvement_Client_View(selectedClient);
                mouvementClientView.ShowDialog();

                // Rafraîchir la liste après modification
                _viewModel.LoadClients();
                ficheClientBindingSource.DataSource = _viewModel.Clients;
            }
        }

        /*
        private void SupprimerClient()
        {
            var selectedClient = _gridView.GetFocusedRow() as Models.FicheClient;
            if (selectedClient != null &&
                XtraMessageBox.Show("Voulez-vous vraiment supprimer ce client?", "Confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_viewModel.SupprimerClient(selectedClient.CodeClient))
                {
                    XtraMessageBox.Show("Client supprimé avec succès");
                    _viewModel.LoadClients();
                    ficheClientBindingSource.DataSource = _viewModel.Clients;
                }
                else
                {
                    XtraMessageBox.Show("Erreur lors de la suppression du client");
                }
            }
        }
        */
    }
}