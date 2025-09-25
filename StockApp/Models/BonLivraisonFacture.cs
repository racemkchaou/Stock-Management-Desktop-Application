using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class BonLivraisonFacture
{
    public int NumeroBlf { get; set; }

    public DateOnly DateBlf { get; set; }

    public int CodeClient { get; set; }

    public string NomClient { get; set; }

    public int? NumeroBc { get; set; }

    public decimal? MontantTotal { get; set; }

    public virtual FicheClient CodeClientNavigation { get; set; }

    public virtual ICollection<LigneBonLivraisonFacture> LigneBonLivraisonFactures { get; set; } = new List<LigneBonLivraisonFacture>();

    public virtual BonCommande NumeroBcNavigation { get; set; }
}
