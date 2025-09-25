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
    public partial class Mouvement_Fournisseur_View : DevExpress.XtraEditors.XtraForm
    {
        private readonly FicheFournisseur _fournisseur;
        private readonly MouvementFournisseurViewModel _viewModel;

        public Mouvement_Fournisseur_View(FicheFournisseur fournisseur)
        {
            InitializeComponent();
            _fournisseur = fournisseur;
            _viewModel = new MouvementFournisseurViewModel(fournisseur);

            // Remplir les champs avec les données du fournisseur
            TE_CodeFournisseur.Text = _fournisseur.CodeFournisseur.ToString();
            TE_NomFournisseur.Text = _fournisseur.NomFournisseur;
            TE_Adresse.Text = _fournisseur.Adresse;
            TE_Tel.Text = _fournisseur.Tel;
            TE_TotalDesAchats.Text = _fournisseur.TotalDesAchats.ToString();

            // Charger les bons d'entrée
            bonEntreeBindingSource.DataSource = _viewModel.BonsEntree;
        }

        private void BT_ModifierFournisseur_Click(object sender, EventArgs e)
        {
            var ficheFournisseur = new Fiche_Fournisseur(_fournisseur);
            if (ficheFournisseur.ShowDialog() == DialogResult.OK)
            {
                // Rafraîchir les données après modification
                _viewModel.LoadBonsEntree();
                bonEntreeBindingSource.DataSource = _viewModel.BonsEntree;

                // Mettre à jour les informations affichées
                TE_NomFournisseur.Text = _fournisseur.NomFournisseur;
                TE_Adresse.Text = _fournisseur.Adresse;
                TE_Tel.Text = _fournisseur.Tel;
            }
        }
    }
}