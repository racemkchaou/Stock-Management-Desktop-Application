using StockApp.Models;
using System.Collections.Generic;
using System.Linq;
using StockApp.Data;

namespace StockApp.ViewModels
{
    public class ListeClientsViewModel
    {
        public List<FicheClient> Clients { get; private set; }

        public ListeClientsViewModel()
        {
            LoadClients();
        }

        public void LoadClients()
        {
            // Implémentez la logique pour charger les clients depuis la base de données
            using (var context = new AppDbContext())
            {
                Clients = context.FicheClients.ToList();
            }
        }

        /*
        public bool SupprimerClient(int codeClient)
        {
            
            // Implémentez la logique de suppression
            using (var context = new AppDbContext())
            {
                var client = context.FicheClients.FirstOrDefault(c => c.CodeClient == codeClient);
                if (client != null)
                {
                    context.FicheClients.Remove(client);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }            
        }
        */
    }
}