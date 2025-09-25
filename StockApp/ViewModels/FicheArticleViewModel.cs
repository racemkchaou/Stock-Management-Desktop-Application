using DevExpress.Mvvm;
using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using StockApp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StockApp.ViewModels
{
    public class FicheArticleViewModel : ViewModelBase
    {
        private readonly AppDbContext _context;
        private bool _isEditMode;

        public int CodeArticle { get; set; }
        public string Designation { get; set; }
        public decimal PrixUnitaireHT { get; set; }
        public double TauxTVA { get; set; }
        public int Quantite { get; set; }
        public decimal PrixUnitaireTTC => PrixUnitaireHT * (1 + (decimal)((double)TauxTVA / 100));

        public bool IsEditMode
        {
            get => _isEditMode;
            set => SetProperty(ref _isEditMode, value, nameof(IsEditMode));
        }

        public FicheArticleViewModel()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StockDB;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;
            _context = new AppDbContext(options);
        }

        public void LoadArticle(FicheArticle article)
        {
            if (article == null) return;

            CodeArticle = article.CodeArticle;
            Designation = article.Designation;
            PrixUnitaireHT = article.PrixUnitaireHorsTaxes;
            TauxTVA = article.TauxDeTva;
            Quantite = article.QuantiteEnStock;

            IsEditMode = true;
        }

        public bool Validate()
        {
            if (CodeArticle < 0)
                return false;

            if (string.IsNullOrWhiteSpace(Designation))
                return false;

            if (PrixUnitaireHT <= 0)
                return false;

            if (TauxTVA < 0)
                return false;

            if (Quantite < 0)
                return false;


            return true;
        }
        public bool ArticleExists(int codeArticle)
        {
            return _context.FicheArticles.Any(f => f.CodeArticle == codeArticle);
        }

        public bool AjouterArticle()
        {
            
            if (!Validate())
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement");
                return false;
            }
            
            if (ArticleExists(this.CodeArticle))
            {
                MessageBox.Show("Un article avec ce code existe déjà");
                return false;
            }
            try
            {
                var nouvelArticle = new FicheArticle
                {
                    CodeArticle = this.CodeArticle,
                    Designation = this.Designation,
                    PrixUnitaireHorsTaxes = this.PrixUnitaireHT,
                    TauxDeTva = this.TauxTVA,
                    QuantiteEnStock = this.Quantite,
                    PrixUnitaireTtc = this.PrixUnitaireTTC
                };

                _context.FicheArticles.Add(nouvelArticle);
                _context.SaveChanges();
                MessageBox.Show("L'article a été créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout : {ex.Message}");
                return false;
            }
        }
        public bool ModifierArticle()
        {
            
            if (!Validate())
            {
                MessageBox.Show("Veuillez remplir tous les champs correctement");
                return false;
            }
            

            try
            {
                using (var context = new AppDbContext())
                {
                    var articleExist = context.FicheArticles.Find(CodeArticle);
                    if (articleExist != null)
                    {
                        // Ne pas modifier la quantité
                        articleExist.Designation = Designation;
                        articleExist.PrixUnitaireHorsTaxes = PrixUnitaireHT;
                        articleExist.TauxDeTva = TauxTVA;
                        articleExist.PrixUnitaireTtc = PrixUnitaireTTC;

                        context.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification : {ex.Message}");
                return false;
            }
        }
    }
}