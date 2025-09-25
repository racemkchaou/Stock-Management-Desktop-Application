using StockApp.Data;
using StockApp.Models;
using System;
using System.Linq;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace StockApp.ViewModels
{
    public class AjouterLigneBonEntreeViewModel
    {
        private AppDbContext _context;

        public AjouterLigneBonEntreeViewModel()
        {
            _context = new AppDbContext();
        }

        public string GetArticleDesignation(string codeArticle)
        {
            if (int.TryParse(codeArticle, out int codeArticleInt))
            {
                var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == codeArticleInt);
                return article?.Designation ?? string.Empty;
            }
            return string.Empty;
        }

        public (decimal PrixHT, decimal TauxTVA) GetArticleInfos(string codeArticle)
        {
            if (int.TryParse(codeArticle, out int codeArticleInt))
            {
                var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == codeArticleInt);
                if (article != null)
                {
                    // Conversion explicite de double à decimal
                    return (article.PrixUnitaireHorsTaxes, (decimal)article.TauxDeTva);
                }
            }
            return (0, 0); // Valeurs par défaut
        }


        public LigneBonEntree ModifierLigne(LigneBonEntree ligneExistante, string codeArticle, string designation,
        int quantite, decimal prixUnitaireHT, decimal tauxTVA)
        {
            try
            {
                // Validation des entrées (identique à AjouterLigne)
                if (!int.TryParse(codeArticle, out int codeArticleInt))
                    throw new ArgumentException("Le code article doit être un nombre entier");

                if (quantite <= 0)
                    throw new ArgumentException("La quantité doit être supérieure à zéro");

                if (prixUnitaireHT <= 0)
                    throw new ArgumentException("Le prix unitaire HT doit être supérieur à zéro");

                if (tauxTVA < 0)
                    throw new ArgumentException("Le taux de TVA ne peut pas être négatif");

                // Calculs
                decimal prixUnitaireTTC = prixUnitaireHT * (1 + tauxTVA / 100);
                decimal total = prixUnitaireTTC * quantite;

                // Mise à jour de la ligne existante
                ligneExistante.Designation = designation;
                ligneExistante.Quantite = quantite;
                ligneExistante.PrixUnitaireHT = prixUnitaireHT;
                ligneExistante.PrixUnitaireTTC = prixUnitaireTTC;
                ligneExistante.TauxTVA = tauxTVA;
                ligneExistante.Total = total;

                return ligneExistante;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public LigneBonEntree AjouterLigne(string codeArticle, string designation, int quantite, decimal prixUnitaireHT, decimal tauxTVA)
        {
            try
            {
                // Validation des entrées
                if (!int.TryParse(codeArticle, out int codeArticleInt))
                    throw new ArgumentException("Le code article doit être un nombre entier");

                if (quantite <= 0)
                    throw new ArgumentException("La quantité doit être supérieure à zéro");

                if (prixUnitaireHT <= 0)
                    throw new ArgumentException("Le prix unitaire HT doit être supérieur à zéro");

                if (tauxTVA < 0)
                    throw new ArgumentException("Le taux de TVA ne peut pas être négatif");

                // Vérifier si l'article existe
                var article = _context.FicheArticles.FirstOrDefault(a => a.CodeArticle == codeArticleInt);
                if (article == null)
                    throw new ArgumentException("L'article spécifié n'existe pas");

                // Calculs
                decimal prixUnitaireTTC = prixUnitaireHT * (1 + tauxTVA / 100);
                decimal total = prixUnitaireTTC * quantite;

                // Création de la ligne
                return new LigneBonEntree
                {
                    CodeArticle = codeArticleInt,
                    Designation = designation,
                    Quantite = quantite,
                    PrixUnitaireHT = prixUnitaireHT,
                    PrixUnitaireTTC = prixUnitaireTTC,
                    TauxTVA = tauxTVA,
                    Total = total
                };
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Erreur: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}