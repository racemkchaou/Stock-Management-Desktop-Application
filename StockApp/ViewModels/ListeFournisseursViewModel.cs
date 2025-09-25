using DevExpress.Mvvm;
using StockApp.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using StockApp.Data;
using StockApp.Models;

namespace StockApp.ViewModels
{
    public class ListeFournisseursViewModel : ViewModelBase
    {
        private BindingList<FicheFournisseur> _fournisseurs;
        public BindingList<FicheFournisseur> Fournisseurs
        {
            get => _fournisseurs;
            set => SetProperty(ref _fournisseurs, value, nameof(Fournisseurs));
        }

        public ListeFournisseursViewModel()
        {
            LoadFournisseurs();
        }

        private void LoadFournisseurs()
        {
            using (var context = new AppDbContext()) // Remplace par ton DbContext exact
            {
                var liste = context.FicheFournisseurs.ToList();
                Fournisseurs = new BindingList<FicheFournisseur>(liste);
            }
        }
    }
}
