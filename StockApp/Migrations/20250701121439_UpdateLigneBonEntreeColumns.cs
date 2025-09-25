using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLigneBonEntreeColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. D'abord supprimer la colonne calculée Total
            migrationBuilder.DropColumn(
                name: "Total",
                table: "LigneBonEntree");

            // 2. Renommer la colonne PrixUnitaire en PrixUnitaireHT
            migrationBuilder.RenameColumn(
                name: "PrixUnitaire",
                table: "LigneBonEntree",
                newName: "PrixUnitaireHT");

            // 3. Ajouter les nouvelles colonnes
            migrationBuilder.AddColumn<decimal>(
                name: "PrixUnitaireTTC",
                table: "LigneBonEntree",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TauxTVA",
                table: "LigneBonEntree",
                type: "decimal(5,2)",
                nullable: false,
                defaultValue: 0m);

            // 4. Recréer la colonne calculée avec la nouvelle formule
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "LigneBonEntree",
                type: "decimal(18,2)",
                computedColumnSql: "([Quantite]*[PrixUnitaireTTC])",
                stored: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // 1. Supprimer la colonne calculée Total
            migrationBuilder.DropColumn(
                name: "Total",
                table: "LigneBonEntree");

            // 2. Supprimer les nouvelles colonnes
            migrationBuilder.DropColumn(
                name: "TauxTVA",
                table: "LigneBonEntree");

            migrationBuilder.DropColumn(
                name: "PrixUnitaireTTC",
                table: "LigneBonEntree");

            // 3. Renommer la colonne PrixUnitaireHT en PrixUnitaire
            migrationBuilder.RenameColumn(
                name: "PrixUnitaireHT",
                table: "LigneBonEntree",
                newName: "PrixUnitaire");

            // 4. Recréer l'ancienne colonne calculée
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "LigneBonEntree",
                type: "decimal(18,2)",
                computedColumnSql: "([Quantite]*[PrixUnitaire])",
                stored: true);
        }
    }
}
