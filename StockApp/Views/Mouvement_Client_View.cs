using DevExpress.XtraEditors;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Mouvement_Client_View : DevExpress.XtraEditors.XtraForm
    {
        private readonly MouvementClientViewModel _viewModel;
        private FicheClient _client; // Changé de readonly à modifiable

        public Mouvement_Client_View(FicheClient client)
        {
            InitializeComponent();

            _client = client; // Maintenant modifiable
            _viewModel = new MouvementClientViewModel(client);

            InitializeData();
            LoadBonLivraisons();
        }

        private void InitializeData()
        {
            TE_CodeClient.Text = _client.CodeClient.ToString();
            TE_NomClient.Text = _client.NomClient;
            TE_Adresse.Text = _client.Adresse;
            TE_Tel.Text = _client.Tel.ToString();
            TE_TotalDesVentes.Text = _client.TotalDesVentes?.ToString("0.00") ?? "0.00";

            // Rendre les champs non modifiables sauf ceux qu'on veut modifier
            TE_CodeClient.Properties.ReadOnly = true;
            TE_TotalDesVentes.Properties.ReadOnly = true;
        }

        private void LoadBonLivraisons()
        {
            bonLivraisonFactureBindingSource.DataSource = _viewModel.GetBonLivraisonsForClient();
            gridControl1.RefreshDataSource();
        }

        private void BT_ModifierClient_Click(object sender, EventArgs e)
        {
            // Préparer les données modifiées
            var clientModifie = new FicheClient
            {
                CodeClient = _client.CodeClient, // Inchangé
                NomClient = TE_NomClient.Text,
                Adresse = TE_Adresse.Text,
                Tel = decimal.TryParse(TE_Tel.Text, out decimal tel) ? tel : 0,
                TotalDesVentes = _client.TotalDesVentes // Inchangé
            };

            // Ouvrir la fiche client avec les données
            var ficheClient = new Fiche_Client(clientModifie, true);
            if (ficheClient.ShowDialog() == DialogResult.OK)
            {
                // Mettre à jour le client avec les nouvelles données
                _client = _viewModel.GetClientById(_client.CodeClient); // Recharger depuis la base

                // Rafraîchir les données affichées
                InitializeData();
                XtraMessageBox.Show("Client modifié avec succès");
            }
        }
    }
}