using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class BonEntree
{
    public int NumeroBe { get; set; }

    public DateOnly DateBe { get; set; }

    public int CodeFournisseur { get; set; }

    public string NomFournisseur { get; set; }

    public DateOnly? DateLivraison { get; set; }

    public decimal? MontantTotal { get; set; }

    public virtual FicheFournisseur CodeFournisseurNavigation { get; set; }

    public virtual ICollection<LigneBonEntree> LigneBonEntrees { get; set; } = new List<LigneBonEntree>();
}
