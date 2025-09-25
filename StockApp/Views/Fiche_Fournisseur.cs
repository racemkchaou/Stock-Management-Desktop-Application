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
    public partial class Fiche_Fournisseur : DevExpress.XtraEditors.XtraForm
    {
        private readonly FicheFournisseurViewModel _viewModel;
        private readonly FicheFournisseur _fournisseur;

        public Fiche_Fournisseur(FicheFournisseur fournisseur)
        {
            InitializeComponent();
            _fournisseur = fournisseur;
            _viewModel = new FicheFournisseurViewModel();

            // Pré-remplir les champs
            TE_NomFournisseur.Text = _fournisseur.NomFournisseur;
            TE_Adresse.Text = _fournisseur.Adresse;
            TE_Tel.Text = _fournisseur.Tel;

            // Changer le texte du bouton
            BT_AjouterFicheFournisseur.Text = "Modifier";
        }

        // Constructeur pour création (sans fournisseur existant)
        public Fiche_Fournisseur()
        {
            InitializeComponent();
            _viewModel = new FicheFournisseurViewModel();
            _fournisseur = new FicheFournisseur();

            // Texte par défaut du bouton
            BT_AjouterFicheFournisseur.Text = "Ajouter";
        }

        private void BT_AjouterFicheFournisseur_Click(object sender, EventArgs e)
        {
            _fournisseur.NomFournisseur = TE_NomFournisseur.Text;
            _fournisseur.Adresse = TE_Adresse.Text;
            _fournisseur.Tel = TE_Tel.Text;

            bool result;
            bool isCreation = BT_AjouterFicheFournisseur.Text == "Ajouter";

            if (isCreation)
            {
                result = _viewModel.AjouterFournisseur(_fournisseur);
            }
            else
            {
                result = _viewModel.ModifierFournisseur(_fournisseur);
            }

            if (result)
            {
                string message = isCreation ? "Fournisseur a été créé avec succès !" : "Fournisseur a été modifié avec succès !";
                MessageBox.Show(message, "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}