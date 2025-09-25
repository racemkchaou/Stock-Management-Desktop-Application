using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using StockApp.Data;
using Microsoft.EntityFrameworkCore;
using StockApp.Views;
using DevExpress.XtraReports.UI;
using StockApp.XtraReports;

namespace StockApp.ViewModels
{
    public class BonCommandeViewModel : INotifyPropertyChanged
    {
        private AppDbContext _context;
        public BonCommande CurrentBonCommande { get; set; }
        public ObservableCollection<LigneBonCommande> LignesCommande { get; set; }
        public ObservableCollection<FicheClient> Clients { get; set; }

        public BonCommandeViewModel()
        {
            _context = new AppDbContext();
            CurrentBonCommande = new BonCommande
            {
                DateBc = DateOnly.FromDateTime(DateTime.Now),
                DateLivraison = DateOnly.FromDateTime(DateTime.Now),
                LigneBonCommandes = new List<LigneBonCommande>()
            };
            LignesCommande = new ObservableCollection<LigneBonCommande>();
            LoadClients();
        }

        private bool _isSavedSuccessfully;
        public bool IsSavedSuccessfully
        {
            get => _isSavedSuccessfully;
            set
            {
                _isSavedSuccessfully = value;
                OnPropertyChanged();
            }
        }

        private decimal? _displayTotal;
        public decimal? DisplayTotal
        {
            get => _displayTotal;
            set
            {
                _displayTotal = value;
                OnPropertyChanged(); // Correction: Utilisez OnPropertyChanged au lieu de RaisePropertyChanged
            }
        }

        private bool _disposed = false;

        // ... votre code existant ...

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }

        public void CalculerTotal()
        {
            CurrentBonCommande.MontantTotal = LignesCommande.Sum(l => l.Total ?? 0);
            DisplayTotal = CurrentBonCommande.MontantTotal;
        }

        private void LoadClients()
        {
            Clients = new ObservableCollection<FicheClient>(_context.FicheClients.ToList());
        }

        private FicheClient _selectedClient;
        public FicheClient SelectedClient
        {
            get => _selectedClient;
            set
            {
                _selectedClient = value;
                OnPropertyChanged();
                if (value != null)
                {
                    CurrentBonCommande.CodeClient = value.CodeClient;
                    CurrentBonCommande.NomClient = value.NomClient;
                    OnPropertyChanged(nameof(CurrentBonCommande));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AjouterLigne(LigneBonCommande ligne)
        {
            LignesCommande.Add(ligne);
            CalculerTotal();
        }

        public void EnregistrerBonCommande()
        {

            // Validation 1: Vérifier qu'un client est sélectionné
            if (CurrentBonCommande.CodeClient == 0 || string.IsNullOrEmpty(CurrentBonCommande.NomClient))
            {
                MessageBox.Show("Veuillez sélectionner un client avant d'enregistrer le bon de commande.",
                              "Client manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsSavedSuccessfully = false;
                return;
            }

            // Validation 2: Vérifier qu'il y a au moins une ligne
            if (LignesCommande.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une ligne au bon de commande avant d'enregistrer.",
                              "Lignes manquantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsSavedSuccessfully = false;
                return;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Vérifier si le bon existe déjà
                    var bonExistant = _context.BonCommandes
                        .Include(b => b.LigneBonCommandes)
                        .FirstOrDefault(b => b.NumeroBc == CurrentBonCommande.NumeroBc);

                    if (bonExistant != null)
                    {
                        // Supprimer les anciennes lignes
                        _context.LigneBonCommandes.RemoveRange(bonExistant.LigneBonCommandes);
                        _context.SaveChanges();

                        // Mettre à jour les propriétés du bon existant au lieu de le supprimer/recréer
                        bonExistant.DateBc = CurrentBonCommande.DateBc;
                        bonExistant.DateLivraison = CurrentBonCommande.DateLivraison;
                        bonExistant.CodeClient = CurrentBonCommande.CodeClient;
                        bonExistant.NomClient = CurrentBonCommande.NomClient;
                        bonExistant.MontantTotal = CurrentBonCommande.MontantTotal;

                        // Attacher les nouvelles lignes
                        foreach (var ligne in LignesCommande)
                        {
                            ligne.Id = 0;
                            ligne.NumeroBc = bonExistant.NumeroBc; // Liaison FK
                            _context.LigneBonCommandes.Add(ligne);
                        }

                        _context.SaveChanges();
                    }
                    else
                    {
                        // Affecter la FK aux lignes du nouveau bon
                        foreach (var ligne in LignesCommande)
                        {
                            ligne.NumeroBc = CurrentBonCommande.NumeroBc;
                        }

                        CurrentBonCommande.LigneBonCommandes = LignesCommande.ToList();
                        _context.BonCommandes.Add(CurrentBonCommande);
                        _context.SaveChanges();
                    }

                    transaction.Commit();

                    IsSavedSuccessfully = true;
                    MessageBox.Show("Bon de commande enregistré avec succès!", "Succès",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    IsSavedSuccessfully = false;
                    MessageBox.Show($"Erreur lors de l'enregistrement: {ex.InnerException?.Message ?? ex.Message}",
                                  "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void ChargerBonCommande(int numeroBc)
        {
            var bon = _context.BonCommandes
                .Include(b => b.LigneBonCommandes)
                .FirstOrDefault(b => b.NumeroBc == numeroBc);

            if (bon != null)
            {
                CurrentBonCommande = bon;
                LignesCommande = new ObservableCollection<LigneBonCommande>(bon.LigneBonCommandes);
                OnPropertyChanged(nameof(CurrentBonCommande));
                OnPropertyChanged(nameof(LignesCommande));
            }
        }

        public LigneBonCommande LigneSelectionnee { get; set; }

        public void ModifierLigne(LigneBonCommande ligneExistante, LigneBonCommande nouvelleLigne)
        {
            var index = LignesCommande.IndexOf(ligneExistante);
            if (index >= 0)
            {
                LignesCommande[index] = nouvelleLigne;
                CalculerTotal();
            }
        }

        public void SupprimerLigne(LigneBonCommande ligne)
        {
            if (LignesCommande.Contains(ligne))
            {
                LignesCommande.Remove(ligne);
                CalculerTotal();
            }
        }

        // Ajoutez cette méthode à votre BonCommandeViewModel
        public void ImprimerBonCommande()
        {
            try
            {
                // Vérifier qu'il y a des lignes à imprimer
                if (LignesCommande == null || LignesCommande.Count == 0)
                {
                    MessageBox.Show("Aucune ligne à imprimer.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Créer le rapport
                var report = new BonCommandeReport(
                    CurrentBonCommande,
                    new List<LigneBonCommande>(LignesCommande));

                // Afficher l'aperçu avant impression
                using (var printTool = new ReportPrintTool(report))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'impression : {ex.Message}",
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}