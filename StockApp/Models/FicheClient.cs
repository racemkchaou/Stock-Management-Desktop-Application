using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class FicheClient
{
    public int CodeClient { get; set; }

    public string NomClient { get; set; }

    public string Adresse { get; set; }

    public decimal? Tel { get; set; }
    
    public decimal? TotalDesVentes { get; set; }

    public virtual ICollection<BonCommande> BonCommandes { get; set; } = new List<BonCommande>();

    public virtual ICollection<BonLivraisonFacture> BonLivraisonFactures { get; set; } = new List<BonLivraisonFacture>();
}
