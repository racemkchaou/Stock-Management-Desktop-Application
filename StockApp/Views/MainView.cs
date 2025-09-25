using DevExpress.Dialogs.Core.View;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockApp.ViewModels;

namespace StockApp.Views
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly MainViewModel _viewModel;

        public MainView()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            _viewModel = new MainViewModel(this);
        }

        private void BT_AfficherProduits_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.ShowArticlesCommand.Execute(null);
        }

        private void BT_AfficherClients_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.ShowClientsCommand.Execute(null);
        }

        private void BT_AfficherFournisseurs_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.ShowFournisseursCommand.Execute(null);
        }

        private void BT_AfficherBons_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.ShowBonsCommand.Execute(null);
        }

        private void BT_AjouterFournisseur_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.AddFournisseurCommand.Execute(null);
        }

        private void BT_AjouterBonCommande_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.AddBonCommandeCommand.Execute(null);
        }
        

        private void BT_AjouterBonEntree_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.AddBonEntreeCommand.Execute(null);
        }
        

        private void BT_AjouterArticle_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.AddArticleCommand.Execute(null);
        }


        private void BT_AjouterBonLivraison_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.AddBonLivraisonCommand.Execute(null);
        }

        private void BT_AjouterClient_ItemClick(object sender, ItemClickEventArgs e)
        {
            _viewModel.AddClientCommand.Execute(null);
        }

    }
}