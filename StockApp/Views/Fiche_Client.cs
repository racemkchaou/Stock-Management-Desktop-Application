using DevExpress.XtraEditors;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Fiche_Client : DevExpress.XtraEditors.XtraForm
    {
        private readonly FicheClientViewModel _viewModel;
        private readonly bool _isModification;
        private readonly FicheClient _client;

        public Fiche_Client(FicheClient client = null, bool isModification = false)
        {
            InitializeComponent();

            _isModification = isModification;
            _client = client ?? new FicheClient();
            _viewModel = new FicheClientViewModel();

            InitializeForm();
        }

        private void InitializeForm()
        {
            if (_isModification)
            {
                Text = "Modifier Client";
                BT_AjouterFicheClient.Text = "Modifier";

                TE_CodeClient.Text = _client.CodeClient.ToString();
                TE_NomClient.Text = _client.NomClient;
                TE_Adresse.Text = _client.Adresse;
                TE_Tel.Text = _client.Tel.ToString();

                TE_CodeClient.Properties.ReadOnly = true;
            }
            else
            {
                Text = "Ajouter Client";
                BT_AjouterFicheClient.Text = "Ajouter";
            }
        }

        private void BT_AjouterFicheClient_Click(object sender, EventArgs e)
        {
            if (!ValiderChamps())
                return;

            var client = new FicheClient
            {
                CodeClient = int.Parse(TE_CodeClient.Text),
                NomClient = TE_NomClient.Text,
                Adresse = TE_Adresse.Text,
                Tel = decimal.Parse(TE_Tel.Text)
            };

            bool result;
            if (_isModification)
            {
                result = _viewModel.ModifierClient(client);
                if (result)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                result = _viewModel.AjouterClient(client);
                if (result)
                {
                    XtraMessageBox.Show("Client ajouté avec succès", "Succès",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }

            if (!result)
            {
                XtraMessageBox.Show(_isModification ?
                    "Erreur lors de la modification du client" :
                    "Erreur lors de l'ajout du client",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValiderChamps()
        {
            if (string.IsNullOrWhiteSpace(TE_CodeClient.Text) || !int.TryParse(TE_CodeClient.Text, out _))
            {
                XtraMessageBox.Show("Code client invalide");
                return false;
            }

            if (string.IsNullOrWhiteSpace(TE_NomClient.Text))
            {
                XtraMessageBox.Show("Nom client requis");
                return false;
            }

            if (string.IsNullOrWhiteSpace(TE_Adresse.Text))
            {
                XtraMessageBox.Show("Adresse requise");
                return false;
            }

            if (!decimal.TryParse(TE_Tel.Text, out _))
            {
                XtraMessageBox.Show("Téléphone invalide");
                return false;
            }

            return true;
        }
    }
}