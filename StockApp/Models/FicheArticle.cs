using System;
using System.Collections.Generic;

namespace StockApp.Models;

public partial class FicheArticle
{
    public int CodeArticle { get; set; }

    public string Designation { get; set; }

    public decimal PrixUnitaireHorsTaxes { get; set; }

    public double TauxDeTva { get; set; }

    public decimal PrixUnitaireTtc { get; set; }

    public int QuantiteEnStock { get; set; }

    public virtual ICollection<LigneBonCommande> LigneBonCommandes { get; set; } = new List<LigneBonCommande>();

    public virtual ICollection<LigneBonEntree> LigneBonEntrees { get; set; } = new List<LigneBonEntree>();

    public virtual ICollection<LigneBonLivraisonFacture> LigneBonLivraisonFactures { get; set; } = new List<LigneBonLivraisonFacture>();
}
