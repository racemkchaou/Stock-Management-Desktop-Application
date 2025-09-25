using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class FicheFournisseur
{
    public int CodeFournisseur { get; set; }

    public string NomFournisseur { get; set; } = null!;

    public string? Adresse { get; set; }

    public string? Tel { get; set; }

    public decimal? TotalDesAchats { get; set; }

    public virtual ICollection<BonEntree> BonEntrees { get; set; } = new List<BonEntree>();
}
