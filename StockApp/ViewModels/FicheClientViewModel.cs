using StockApp.Models;
using System.Linq;
using StockApp.Data;

namespace StockApp.ViewModels
{
    public class FicheClientViewModel
    {
        public bool AjouterClient(FicheClient client)
        {
            // Implémentez la logique d'ajout
            using (var context = new AppDbContext())
            {
                if (context.FicheClients.Any(c => c.CodeClient == client.CodeClient))
                {
                    return false; // Client existe déjà
                }

                context.FicheClients.Add(client);
                context.SaveChanges();
                return true;
            }
        }

        public bool ModifierClient(FicheClient client)
        {
            // Implémentez la logique de modification
            using (var context = new AppDbContext())
            {
                var existingClient = context.FicheClients.FirstOrDefault(c => c.CodeClient == client.CodeClient);
                if (existingClient == null)
                {
                    return false;
                }

                existingClient.NomClient = client.NomClient;
                existingClient.Adresse = client.Adresse;
                existingClient.Tel = client.Tel;

                context.SaveChanges();
                return true;
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