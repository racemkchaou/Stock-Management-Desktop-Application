using DevExpress.Mvvm;
using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using StockApp.Models;
using System;
using System.Windows.Forms;

namespace StockApp.ViewModels
{
    public class FicheFournisseurViewModel : ViewModelBase
    {
        private readonly AppDbContext _context;

        public FicheFournisseurViewModel()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StockDB;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;
            _context = new AppDbContext(options);
        }

        private bool Validate(FicheFournisseur fournisseur)
        {
            if (string.IsNullOrWhiteSpace(fournisseur.NomFournisseur))
            {
                MessageBox.Show("Le nom du fournisseur est obligatoire");
                return false;
            }

            if (string.IsNullOrWhiteSpace(fournisseur.Adresse))
            {
                MessageBox.Show("L'adresse du fournisseur est obligatoire");
                return false;
            }

            return true;
        }

        public bool AjouterFournisseur(FicheFournisseur fournisseur)
        {
            if (!Validate(fournisseur))
            {
                return false;
            }

            try
            {
                fournisseur.TotalDesAchats = 0; // Initialiser à 0
                _context.FicheFournisseurs.Add(fournisseur);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout du fournisseur : {ex.Message}");
                return false;
            }
        }

        public bool ModifierFournisseur(FicheFournisseur fournisseur)
        {
            if (!Validate(fournisseur))
            {
                return false;
            }

            try
            {
                var existingFournisseur = _context.FicheFournisseurs.Find(fournisseur.CodeFournisseur);
                if (existingFournisseur != null)
                {
                    // Ne pas modifier le code fournisseur ni le total des achats
                    existingFournisseur.NomFournisseur = fournisseur.NomFournisseur;
                    existingFournisseur.Adresse = fournisseur.Adresse;
                    existingFournisseur.Tel = fournisseur.Tel;

                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification du fournisseur : {ex.Message}");
                return false;
            }
        }
    }
}