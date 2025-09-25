using StockApp.Data;
using StockApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace StockApp.ViewModels
{
    public class ListeBonsViewModel : INotifyPropertyChanged
    {
        private AppDbContext _context;
        private string _natureBonSelectionnee = "Tous les bons";
        private DateTime _dateDebut = DateTime.Today.AddMonths(-1);
        private DateTime _dateFin = DateTime.Today;
        private string _nomPrenom;
        private string _numeroBon;

        public ListeBonsViewModel()
        {
            _context = new AppDbContext();
            NaturesBons = new List<string> { "Tous les bons", "Bon de commande", "Bon de livraison", "Bon d'entrée" };
            Bons = new List<BonViewModel>();
            ChargerBons();
        }

        public List<string> NaturesBons { get; }
        public List<BonViewModel> Bons { get; private set; }

        public string NatureBonSelectionnee
        {
            get => _natureBonSelectionnee;
            set
            {
                if (_natureBonSelectionnee != value)
                {
                    _natureBonSelectionnee = value;
                    OnPropertyChanged();
                    ChargerBons();
                }
            }
        }

        public DateTime DateDebut
        {
            get => _dateDebut;
            set
            {
                if (_dateDebut != value)
                {
                    _dateDebut = value;
                    OnPropertyChanged();
                    ChargerBons();
                }
            }
        }

        public DateTime DateFin
        {
            get => _dateFin;
            set
            {
                if (_dateFin != value)
                {
                    _dateFin = value;
                    OnPropertyChanged();
                    ChargerBons();
                }
            }
        }

        public string NomPrenom
        {
            get => _nomPrenom;
            set
            {
                if (_nomPrenom != value)
                {
                    _nomPrenom = value;
                    OnPropertyChanged();
                    ChargerBons();
                }
            }
        }

        public string NumeroBon
        {
            get => _numeroBon;
            set
            {
                if (_numeroBon != value)
                {
                    _numeroBon = value;
                    OnPropertyChanged();
                    ChargerBons();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RafraichirDonnees()
        {
            // Détruire et recréer le contexte pour être sûr d'avoir les dernières données
            _context.Dispose();
            _context = new AppDbContext();
            ChargerBons();
        }

        public void ChargerBons()
        {
            try
            {
                var dateDebutOnly = DateOnly.FromDateTime(DateDebut);
                var dateFinOnly = DateOnly.FromDateTime(DateFin);
                var nomPrenomLower = NomPrenom?.ToLower();

                var resultats = new List<BonViewModel>();

                // Filtrage des bons de commande
                if (NatureBonSelectionnee == "Tous les bons" || NatureBonSelectionnee == "Bon de commande")
                {
                    var commandes = _context.BonCommandes
                        .Where(b => b.DateBc >= dateDebutOnly && b.DateBc <= dateFinOnly)
                        .AsEnumerable()
                        .Select(b => new BonViewModel
                        {
                            Numero = b.NumeroBc.ToString(),
                            Date = new DateTime(b.DateBc.Year, b.DateBc.Month, b.DateBc.Day),
                            NomPrenom = b.NomClient,
                            MontantTotal = b.MontantTotal,
                            Nature = "Bon de commande"
                        });

                    if (!string.IsNullOrEmpty(NumeroBon))
                        commandes = commandes.Where(c =>
                            c.Numero.Contains(NumeroBon, StringComparison.OrdinalIgnoreCase));

                    if (!string.IsNullOrEmpty(nomPrenomLower))
                        commandes = commandes.Where(c =>
                            c.NomPrenom.ToLower().Contains(nomPrenomLower));

                    resultats.AddRange(commandes);
                }

                // Filtrage des bons de livraison
                if (NatureBonSelectionnee == "Tous les bons" || NatureBonSelectionnee == "Bon de livraison")
                {
                    var livraisons = _context.BonLivraisonFactures
                        .Where(b => b.DateBlf >= dateDebutOnly && b.DateBlf <= dateFinOnly)
                        .AsEnumerable()
                        .Select(b => new BonViewModel
                        {
                            Numero = b.NumeroBlf.ToString(),
                            Date = new DateTime(b.DateBlf.Year, b.DateBlf.Month, b.DateBlf.Day),
                            NomPrenom = b.NomClient,
                            MontantTotal = b.MontantTotal,
                            Nature = "Bon de livraison"
                        });

                    if (!string.IsNullOrEmpty(NumeroBon))
                        livraisons = livraisons.Where(l =>
                            l.Numero.Contains(NumeroBon, StringComparison.OrdinalIgnoreCase));

                    if (!string.IsNullOrEmpty(nomPrenomLower))
                        livraisons = livraisons.Where(l =>
                            l.NomPrenom.ToLower().Contains(nomPrenomLower));

                    resultats.AddRange(livraisons);
                }

                // Filtrage des bons d'entrée
                if (NatureBonSelectionnee == "Tous les bons" || NatureBonSelectionnee == "Bon d'entrée")
                {
                    var entrees = _context.BonEntrees
                        .Where(b => b.DateBe >= dateDebutOnly && b.DateBe <= dateFinOnly)
                        .AsEnumerable()
                        .Select(b => new BonViewModel
                        {
                            Numero = b.NumeroBe.ToString(),
                            Date = new DateTime(b.DateBe.Year, b.DateBe.Month, b.DateBe.Day),
                            NomPrenom = b.NomFournisseur,
                            MontantTotal = b.MontantTotal,
                            Nature = "Bon d'entrée"
                        });

                    if (!string.IsNullOrEmpty(NumeroBon))
                        entrees = entrees.Where(e =>
                            e.Numero.Contains(NumeroBon, StringComparison.OrdinalIgnoreCase));

                    if (!string.IsNullOrEmpty(nomPrenomLower))
                        entrees = entrees.Where(e =>
                            e.NomPrenom.ToLower().Contains(nomPrenomLower));

                    resultats.AddRange(entrees);
                }

                Bons = resultats.OrderByDescending(b => b.Date).ToList();
                OnPropertyChanged(nameof(Bons));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des bons: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class BonViewModel
    {
        public string Numero { get; set; }
        public DateTime Date { get; set; }
        public string NomPrenom { get; set; }
        public decimal? MontantTotal { get; set; }
        public string Nature { get; set; }
    }
}