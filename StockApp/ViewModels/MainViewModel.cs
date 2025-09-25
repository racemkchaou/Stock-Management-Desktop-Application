using DevExpress.Mvvm;
using StockApp.Views;
using System.Windows.Forms;

namespace StockApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly Form _mainForm;
        private DelegateCommand _showArticlesCommand;
        private DelegateCommand _showClientsCommand;
        private DelegateCommand _showFournisseursCommand;
        private DelegateCommand _showBonsCommand;

        public MainViewModel(Form mainForm)
        {
            _mainForm = mainForm;
        }

        // Commandes en propriétés (une seule déclaration chacune)
        public DelegateCommand ShowArticlesCommand => new DelegateCommand(() =>
        {
            var form = new Liste_Articles_View();
            form.ShowDialog();
        });

        public DelegateCommand ShowClientsCommand => new DelegateCommand(() =>
        {
            var form = new Liste_Clients_View();
            form.ShowDialog();
        });

        public DelegateCommand ShowFournisseursCommand => new DelegateCommand(() =>
        {
            var form = new Liste_Fournisseurs_View();
            form.ShowDialog();
        });

        public DelegateCommand ShowBonsCommand => new DelegateCommand(() =>
        {
            var form = new Liste_Bons();
            form.ShowDialog();
        });


        public DelegateCommand AddFournisseurCommand => new DelegateCommand(() =>
        {
            var form = new Fiche_Fournisseur();
            form.ShowDialog(); // Affichage modale
        });

        public DelegateCommand AddBonCommandeCommand => new DelegateCommand(() =>
        {
            var viewModel = new BonCommandeViewModel();
            var form = new Bon_Commande_Form_View(viewModel);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Bon de commande enregistré !");
            }
        });

        private void ShowForm(Form form)
        {
            form.MdiParent = _mainForm;
            form.Show();
        }

        public DelegateCommand AddBonEntreeCommand => new DelegateCommand(() =>
        {
            var viewModel = new BonEntreeViewModel();
            var form = new Bon_Entree_Form_View(viewModel);
            if (form.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Bon d'entrée ajouté !");
        });

        public DelegateCommand AddArticleCommand => new DelegateCommand(() =>
        {
            var form = new Fiche_Article();
            form.ShowDialog();
        });

        public DelegateCommand AddBonLivraisonCommand => new DelegateCommand(() =>
        {
            var viewModel = new BonLivraisonViewModel();
            var form = new Bon_Livraison_Form_View(viewModel);
            if (form.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Bon de livraison enregistré !");
        });

        public DelegateCommand AddClientCommand => new DelegateCommand(() =>
        {
            var form = new Fiche_Client();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Le message est maintenant géré dans Fiche_Client
                // Pas besoin de le répéter ici
            }
        });



    }
}