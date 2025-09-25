using StockApp.Models;
using System.Collections.Generic;
using System.Linq;
using StockApp.Data;

namespace StockApp.ViewModels
{
    public class MouvementClientViewModel
    {
        private readonly FicheClient _client;

        public MouvementClientViewModel(FicheClient client)
        {
            _client = client;
        }

        public List<BonLivraisonFacture> GetBonLivraisonsForClient()
        {
            // Implémentez la logique pour charger les BLs du client
            using (var context = new AppDbContext())
            {
                return context.BonLivraisonFactures
                    .Where(b => b.CodeClient == _client.CodeClient)
                    .ToList();
            }
        }

        public FicheClient GetClientById(int codeClient)
        {
            using (var context = new AppDbContext())
            {
                return context.FicheClients.FirstOrDefault(c => c.CodeClient == codeClient);
            }
        }
    }
}