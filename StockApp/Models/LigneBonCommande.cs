using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class LigneBonCommande
{
    public int Id { get; set; }

    public int NumeroBc { get; set; }

    public int? CodeArticle { get; set; }

    public string Designation { get; set; }

    public int Quantite { get; set; }

    public decimal PrixUnitaire { get; set; }

    public decimal? Total { get; set; }

    public virtual FicheArticle CodeArticleNavigation { get; set; }

    public virtual BonCommande NumeroBcNavigation { get; set; }
}
