using DevExpress.Mvvm;
using StockApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using StockApp.Data;
using System.Windows.Forms;

namespace StockApp.ViewModels
{
    public class ListeArticlesViewModel : ViewModelBase
    {
        private BindingList<FicheArticle> _articles;
        private FicheArticle _selectedArticle;

        public BindingList<FicheArticle> Articles
        {
            get => _articles;
            set => SetProperty(ref _articles, value, nameof(Articles));
        }

        public FicheArticle SelectedArticle
        {
            get => _selectedArticle;
            set => SetProperty(ref _selectedArticle, value, nameof(SelectedArticle));
        }

        public ListeArticlesViewModel()
        {
            LoadArticles();
        }

        public void LoadArticles()
        {
            using (var context = new AppDbContext())
            {
                var list = context.FicheArticles.ToList();
                Articles = new BindingList<FicheArticle>(list);
            }
        }

        public void ModifierArticle(FicheArticle articleModifie)
        {
            using (var context = new AppDbContext())
            {
                var articleExist = context.FicheArticles.Find(articleModifie.CodeArticle);
                if (articleExist != null)
                {
                    // Copier toutes les propriétés SAUF la quantité
                    articleExist.Designation = articleModifie.Designation;
                    articleExist.PrixUnitaireHorsTaxes = articleModifie.PrixUnitaireHorsTaxes;
                    articleExist.TauxDeTva = articleModifie.TauxDeTva;
                    articleExist.PrixUnitaireTtc = articleModifie.PrixUnitaireTtc;

                    context.SaveChanges();

                    // Rafraîchir localement
                    var articleLocal = Articles.FirstOrDefault(a => a.CodeArticle == articleModifie.CodeArticle);
                    if (articleLocal != null)
                    {
                        articleLocal.Designation = articleModifie.Designation;
                        articleLocal.PrixUnitaireHorsTaxes = articleModifie.PrixUnitaireHorsTaxes;
                        articleLocal.TauxDeTva = articleModifie.TauxDeTva;
                        articleLocal.PrixUnitaireTtc = articleModifie.PrixUnitaireTtc;
                    }
                }
            }
        }
    }
}