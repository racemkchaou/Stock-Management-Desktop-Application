using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class LigneBonEntree
{
    public int Id { get; set; }

    public int NumeroBe { get; set; }

    public int? CodeArticle { get; set; }

    public string Designation { get; set; }

    public int Quantite { get; set; }

    public decimal PrixUnitaireHT { get; set; }

    public decimal PrixUnitaireTTC { get; set; }

    public decimal TauxTVA { get; set; } 

    public decimal? Total { get; set; }

    public virtual FicheArticle CodeArticleNavigation { get; set; }

    public virtual BonEntree NumeroBeNavigation { get; set; }
}
