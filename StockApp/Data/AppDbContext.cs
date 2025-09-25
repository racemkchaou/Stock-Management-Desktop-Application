using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StockApp.Models;

namespace StockApp.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BonCommande> BonCommandes { get; set; }

    public virtual DbSet<BonEntree> BonEntrees { get; set; }

    public virtual DbSet<BonLivraisonFacture> BonLivraisonFactures { get; set; }

    public virtual DbSet<FicheArticle> FicheArticles { get; set; }

    public virtual DbSet<FicheClient> FicheClients { get; set; }

    public virtual DbSet<FicheFournisseur> FicheFournisseurs { get; set; }

    public virtual DbSet<LigneBonCommande> LigneBonCommandes { get; set; }

    public virtual DbSet<LigneBonEntree> LigneBonEntrees { get; set; }

    public virtual DbSet<LigneBonLivraisonFacture> LigneBonLivraisonFactures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=StockDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BonCommande>(entity =>
        {
            entity.HasKey(e => e.NumeroBc).HasName("PK__BonComma__C664DCC4FEF37197");

            entity.ToTable("BonCommande");

            entity.Property(e => e.NumeroBc).HasColumnName("NumeroBC");
            entity.Property(e => e.DateBc).HasColumnName("DateBC");
            entity.Property(e => e.MontantTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NomClient)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.CodeClientNavigation).WithMany(p => p.BonCommandes)
                .HasForeignKey(d => d.CodeClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BonCommande_FicheClient");
        });

        modelBuilder.Entity<BonEntree>(entity =>
        {
            entity.HasKey(e => e.NumeroBe).HasName("PK__BonEntre__C664DCC67DAC2BBA");

            entity.ToTable("BonEntree");

            entity.Property(e => e.NumeroBe).HasColumnName("NumeroBE").ValueGeneratedOnAdd(); ;
            entity.Property(e => e.DateBe).HasColumnName("DateBE");
            entity.Property(e => e.MontantTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NomFournisseur)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.CodeFournisseurNavigation).WithMany(p => p.BonEntrees)
                .HasForeignKey(d => d.CodeFournisseur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BonEntree_FicheFournisseur");
        });

        modelBuilder.Entity<BonLivraisonFacture>(entity =>
        {
            entity.HasKey(e => e.NumeroBlf).HasName("PK__BonLivra__E37FEC34C4145BAF");

            entity.ToTable("BonLivraisonFacture");

            entity.Property(e => e.NumeroBlf).HasColumnName("NumeroBLF");
            entity.Property(e => e.DateBlf).HasColumnName("DateBLF");
            entity.Property(e => e.MontantTotal).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NomClient)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.NumeroBc).HasColumnName("NumeroBC");

            entity.HasOne(d => d.CodeClientNavigation).WithMany(p => p.BonLivraisonFactures)
                .HasForeignKey(d => d.CodeClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BonLivraisonFacture_FicheClient");

            entity.HasOne(d => d.NumeroBcNavigation).WithMany(p => p.BonLivraisonFactures)
                .HasForeignKey(d => d.NumeroBc)
                .HasConstraintName("FK__BonLivrai__Numer__403A8C7D");
        });

        modelBuilder.Entity<FicheArticle>(entity =>
        {
            entity.HasKey(e => e.CodeArticle);

            entity.ToTable("FICHE_ARTICLE");

            entity.Property(e => e.CodeArticle)
                .ValueGeneratedNever()
                .HasColumnName("CODE_ARTICLE");
            entity.Property(e => e.Designation)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.PrixUnitaireHorsTaxes)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PRIX_UNITAIRE_Hors_Taxes");
            entity.Property(e => e.PrixUnitaireTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PRIX_UNITAIRE_TTC");
            entity.Property(e => e.QuantiteEnStock).HasColumnName("QUANTITE_EN_STOCK");
            entity.Property(e => e.TauxDeTva).HasColumnName("TAUX_DE_TVA");
        });

        modelBuilder.Entity<FicheClient>(entity =>
        {
            entity.HasKey(e => e.CodeClient);

            entity.ToTable("FICHE_CLIENT");

            entity.Property(e => e.CodeClient)
                .ValueGeneratedNever()
                .HasColumnName("CODE_CLIENT");
            entity.Property(e => e.Adresse)
                .HasMaxLength(150)
                .HasColumnName("ADRESSE");
            entity.Property(e => e.NomClient)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("NOM_CLIENT");
            entity.Property(e => e.Tel)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("TEL");
            entity.Property(e => e.TotalDesVentes)
                .HasColumnType("decimal(20, 4)")
                .HasColumnName("TOTAL_DES_VENTES");
        });

        modelBuilder.Entity<FicheFournisseur>(entity =>
        {
            entity.HasKey(e => e.CodeFournisseur).HasName("PK__FICHE_FO__2295BC29A126E020");

            entity.ToTable("FICHE_FOURNISSEUR");

            entity.Property(e => e.CodeFournisseur).HasColumnName("CODE_FOURNISSEUR");
            entity.Property(e => e.Adresse)
                .HasMaxLength(200)
                .HasColumnName("ADRESSE");
            entity.Property(e => e.NomFournisseur)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("NOM_FOURNISSEUR");
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .HasColumnName("TEL");
            entity.Property(e => e.TotalDesAchats)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("TOTAL_DES_ACHATS");
        });

        modelBuilder.Entity<LigneBonCommande>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LigneBon__3214EC07A8673453");

            entity.ToTable("LigneBonCommande");

            entity.Property(e => e.Designation)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.NumeroBc).HasColumnName("NumeroBC");
            entity.Property(e => e.PrixUnitaire).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Total)
                .HasComputedColumnSql("([Quantite]*[PrixUnitaire])", true)
                .HasColumnType("decimal(29, 2)");

            entity.HasOne(d => d.CodeArticleNavigation).WithMany(p => p.LigneBonCommandes)
                .HasForeignKey(d => d.CodeArticle)
                .HasConstraintName("FK_BonCommande2_FicheArticle2");

            entity.HasOne(d => d.NumeroBcNavigation).WithMany(p => p.LigneBonCommandes)
                .HasForeignKey(d => d.NumeroBc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneBonC__Numer__3D5E1FD2");
        });

        modelBuilder.Entity<LigneBonEntree>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LigneBon__3214EC07DE4B4D75");

            entity.ToTable("LigneBonEntree");

            entity.Property(e => e.Designation)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.NumeroBe).HasColumnName("NumeroBE");
            entity.Property(e => e.PrixUnitaireHT).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PrixUnitaireTTC).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TauxTVA).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Total)
                .HasComputedColumnSql("([Quantite]*[PrixUnitaireTTC])", true)
                .HasColumnType("decimal(29, 2)");

            entity.HasOne(d => d.CodeArticleNavigation).WithMany(p => p.LigneBonEntrees)
                .HasForeignKey(d => d.CodeArticle)
                .HasConstraintName("FK_BonEntree2_FicheArticle2");

            entity.HasOne(d => d.NumeroBeNavigation).WithMany(p => p.LigneBonEntrees)
                .HasForeignKey(d => d.NumeroBe)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneBonE__Numer__47DBAE45");
        });

        modelBuilder.Entity<LigneBonLivraisonFacture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LigneBon__3214EC0766380865");

            entity.ToTable("LigneBonLivraisonFacture");

            entity.Property(e => e.Designation)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.NumeroBlf).HasColumnName("NumeroBLF");
            entity.Property(e => e.PrixUnitaire).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Total)
                .HasComputedColumnSql("([Quantite]*[PrixUnitaire])", true)
                .HasColumnType("decimal(29, 2)");

            entity.HasOne(d => d.CodeArticleNavigation).WithMany(p => p.LigneBonLivraisonFactures)
                .HasForeignKey(d => d.CodeArticle)
                .HasConstraintName("FK_BonLivraisonFacture2_FicheArticle2");

            entity.HasOne(d => d.NumeroBlfNavigation).WithMany(p => p.LigneBonLivraisonFactures)
                .HasForeignKey(d => d.NumeroBlf)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneBonL__Numer__4316F928");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
