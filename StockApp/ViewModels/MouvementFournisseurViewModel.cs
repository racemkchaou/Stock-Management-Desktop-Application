using DevExpress.Mvvm;
using Microsoft.EntityFrameworkCore;
using StockApp.Data;
using StockApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace StockApp.ViewModels
{
    public class MouvementFournisseurViewModel : ViewModelBase
    {
        private readonly AppDbContext _context;
        private readonly FicheFournisseur _fournisseur;

        public List<BonEntree> BonsEntree { get; private set; }

        public MouvementFournisseurViewModel(FicheFournisseur fournisseur)
        {
            _fournisseur = fournisseur;

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=StockDB;Trusted_Connection=True;TrustServerCertificate=True;")
                .Options;
            _context = new AppDbContext(options);

            LoadBonsEntree();
        }

        public void LoadBonsEntree()
        {
            BonsEntree = _context.BonEntrees
                .Where(be => be.CodeFournisseur == _fournisseur.CodeFournisseur)
                .ToList();
        }
    }
}