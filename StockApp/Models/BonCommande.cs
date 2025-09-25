using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class BonCommande
{
    public int NumeroBc { get; set; }

    public DateOnly DateBc { get; set; }

    public int CodeClient { get; set; }

    public string NomClient { get; set; }

    public DateOnly? DateLivraison { get; set; }

    public decimal? MontantTotal { get; set; }

    public virtual ICollection<BonLivraisonFacture> BonLivraisonFactures { get; set; } = new List<BonLivraisonFacture>();

    public virtual FicheClient CodeClientNavigation { get; set; }

    public virtual ICollection<LigneBonCommande> LigneBonCommandes { get; set; } = new List<LigneBonCommande>();
}
