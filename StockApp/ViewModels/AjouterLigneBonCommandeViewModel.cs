using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StockApp.Data; 

namespace StockApp.ViewModels
{
    public class AjouterLigneBonCommandeViewModel
    {
        private AppDbContext _context;
        public List<FicheArticle> Articles { get; set; }

        public AjouterLigneBonCommandeViewModel()
        {
            _context = new AppDbContext();
            LoadArticles();
        }

        private void LoadArticles()
        {
            Articles = _context.FicheArticles.ToList();
        }

        public LigneBonCommande CreerLigneAvecValidationStock(int codeArticle, int quantite, out bool continuer)
        {
            continuer = false;

            var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == codeArticle);
            if (article == null)
            {
                MessageBox.Show("Article introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (quantite > article.QuantiteEnStock)
            {
                string message = $"Stock insuffisant !\n\n" +
                                 $"Quantité demandée : {quantite}\n" +
                                 $"Stock disponible : {article.QuantiteEnStock}\n\n" +
                                 $"Voulez-vous quand même continuer ?";

                var result = MessageBox.Show(message, "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return null;
                }
            }

            continuer = true;

            return new LigneBonCommande
            {
                CodeArticle = article.CodeArticle,
                Designation = article.Designation,
                Quantite = quantite,
                PrixUnitaire = article.PrixUnitaireTtc,
                Total = quantite * article.PrixUnitaireTtc
            };
        }
        public void LoadArticleInfo(int codeArticle, out string designation, out decimal prixUnitaireTTC)
        {
            var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == codeArticle);
            if (article != null)
            {
                designation = article.Designation;
                // Prix TTC avec +10%
                prixUnitaireTTC = article.PrixUnitaireTtc * 1.10m;
            }
            else
            {
                designation = string.Empty;
                prixUnitaireTTC = 0;
            }
        }
    }
}