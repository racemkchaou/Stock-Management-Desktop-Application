using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using StockApp.Models;
using StockApp.ViewModels;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace StockApp.Views
{
    public partial class Liste_Articles_View : DevExpress.XtraEditors.XtraForm
    {
        private readonly ListeArticlesViewModel _viewModel;
        private BarManager _barManager;
        private PopupMenu _contextMenu;

        public Liste_Articles_View()
        {
            InitializeComponent();

            // Initialisation du ViewModel
            _viewModel = new ListeArticlesViewModel();
            ficheArticleBindingSource.DataSource = _viewModel.Articles;

            // Configuration du menu contextuel
            ConfigureContextMenu();

            // Abonnement aux événements
            gridView1.PopupMenuShowing += GridView1_PopupMenuShowing;
            gridView1.RowClick += GridView1_RowClick;
        }

        private void ConfigureContextMenu()
        {
            // Création du BarManager
            _barManager = new BarManager();
            _barManager.Form = this;
            _barManager.ForceInitialize();

            // Création du menu contextuel
            _contextMenu = new PopupMenu(_barManager);

            // Ajout de l'option "Modifier"
            var btnModifier = new BarButtonItem(_barManager, "Modifier l'article");
            btnModifier.ItemClick += (s, e) => OuvrirFicheModification();

            _contextMenu.AddItem(btnModifier);
        }

        private void GridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.InRow)
            {
                // Sélection de l'article
                _viewModel.SelectedArticle = gridView1.GetRow(e.HitInfo.RowHandle) as FicheArticle;

                // Affichage du menu contextuel
                _contextMenu.ShowPopup(Cursor.Position);
                e.Allow = false;
            }
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Left) // Double-clic gauche
            {
                _viewModel.SelectedArticle = gridView1.GetRow(e.RowHandle) as FicheArticle;
                OuvrirFicheModification();
            }
        }

        private void OuvrirFicheModification()
        {
            if (_viewModel.SelectedArticle == null) return;

            // Sauvegarder l'article sélectionné
            var articleSelectionne = _viewModel.SelectedArticle;

            using (var ficheArticleView = new Fiche_Article())
            {
                ficheArticleView.SetArticle(articleSelectionne);

                if (ficheArticleView.ShowDialog() == DialogResult.OK)
                {
                    // 1. Mettre à jour le ViewModel
                    _viewModel.ModifierArticle(ficheArticleView.GetArticleModifie());

                    // 2. Recharger les données depuis la base
                    _viewModel.LoadArticles();

                    // 3. Rafraîchir le BindingSource
                    ficheArticleBindingSource.ResetBindings(false);

                    // 4. Resélectionner l'article modifié
                    var index = _viewModel.Articles.IndexOf(articleSelectionne);
                    if (index >= 0)
                    {
                        gridView1.FocusedRowHandle = index;
                    }                    
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _barManager?.Dispose();
            _contextMenu?.Dispose();
            base.OnFormClosing(e);
        }

    }
}