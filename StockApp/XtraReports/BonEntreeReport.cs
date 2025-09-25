using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace StockApp.XtraReports
{
    public partial class BonEntreeReport : XtraReport
    {
        public BonEntreeReport(BonEntree bonEntree, List<LigneBonEntree> lignes)
        {
            // Configuration de base
            this.Margins = new Margins(30, 30, 40, 60); // Gauche, Droite, Haut, Bas
            this.PageWidth = 800;
            this.PageHeight = 1100;

            // Création des bandes dans le bon ordre
            CreateReportBands(bonEntree, lignes);
        }

        private void CreateReportBands(BonEntree bonEntree, List<LigneBonEntree> lignes)
        {
            // 1. Bande de titre (TopMarginBand)
            var topMargin = new TopMarginBand
            {
                Height = 80,
                Name = "topMarginBand"
            };

            var lblTitle = new XRLabel
            {
                Text = $"BON D'ENTRÉE N°{bonEntree.NumeroBe}",
                Location = new Point(0, 20),
                Width = GetContentWidth(),
                TextAlignment = TextAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Navy
            };
            topMargin.Controls.Add(lblTitle);
            this.Bands.Add(topMargin);

            // 2. Bande de détail (DetailBand)
            var detailBand = new DetailBand
            {
                Height = CalculateDetailHeight(lignes.Count),
                Name = "detailBand"
            };

            // Tableau des informations
            var tableInfos = new XRTable
            {
                Location = new Point(0, 10),
                Width = GetContentWidth()
            };

            var rowDate = new XRTableRow();
            rowDate.Cells.Add(CreateTableCell("Date BE:", 100));
            rowDate.Cells.Add(CreateTableCell(bonEntree.DateBe.ToString("dd/MM/yyyy"), 200));
            tableInfos.Rows.Add(rowDate);

            var rowFournisseur = new XRTableRow();
            rowFournisseur.Cells.Add(CreateTableCell("Fournisseur:", 100));
            rowFournisseur.Cells.Add(CreateTableCell(
                $"{bonEntree.CodeFournisseur} - {bonEntree.NomFournisseur}", 300));
            tableInfos.Rows.Add(rowFournisseur);

            detailBand.Controls.Add(tableInfos);

            // Tableau des lignes
            var tableLignes = CreateLinesTable(lignes);
            tableLignes.Location = new Point(0, 50);
            detailBand.Controls.Add(tableLignes);

            this.Bands.Add(detailBand);

            // 3. Bande de total (ReportFooterBand)
            var reportFooter = new ReportFooterBand
            {
                Height = 40,
                Name = "reportFooterBand"
            };

            var tableTotal = new XRTable
            {
                Location = new Point(0, 0),
                Width = GetContentWidth()
            };

            var totalRow = new XRTableRow
            {
                BackColor = Color.LightGray,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            totalRow.Cells.Add(CreateTotalCell("TOTAL GENERAL:", 580, TextAlignment.MiddleRight));
            totalRow.Cells.Add(CreateTotalCell(bonEntree.MontantTotal?.ToString("N2") + " DT", 100, TextAlignment.MiddleRight));
            tableTotal.Rows.Add(totalRow);
            reportFooter.Controls.Add(tableTotal);

            this.Bands.Add(reportFooter);

            // 4. Bande de signature (BottomMarginBand)
            var bottomMargin = new BottomMarginBand
            {
                Height = 90,
                Name = "bottomMarginBand"
            };

            var lblSignature = new XRLabel
            {
                Text = "Signature",
                Location = new Point(GetContentWidth() - 150, 15),
                Width = 150,
                TextAlignment = TextAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Italic)
            };
            bottomMargin.Controls.Add(lblSignature);

            this.Bands.Add(bottomMargin);
        }

        private int GetContentWidth()
        {
            return (int)(this.PageWidth - this.Margins.Left - this.Margins.Right);
        }

        private int CalculateDetailHeight(int ligneCount)
        {
            // Hauteur de base + 20px par ligne
            return 60 + (ligneCount * 20);
        }

        private XRTable CreateLinesTable(List<LigneBonEntree> lignes)
        {
            var table = new XRTable
            {
                Width = GetContentWidth(),
                Borders = BorderSide.All
            };

            // En-tête des colonnes
            var headerRow = new XRTableRow
            {
                BackColor = Color.LightGray,
                Font = new Font("Arial", 9, FontStyle.Bold)
            };

            headerRow.Cells.Add(CreateTableCell("Code", 80));
            headerRow.Cells.Add(CreateTableCell("Désignation", 200));
            headerRow.Cells.Add(CreateTableCell("Qté", 60, TextAlignment.MiddleRight));
            headerRow.Cells.Add(CreateTableCell("Prix HT", 80, TextAlignment.MiddleRight));
            headerRow.Cells.Add(CreateTableCell("TVA", 60, TextAlignment.MiddleRight));
            headerRow.Cells.Add(CreateTableCell("Prix TTC", 80, TextAlignment.MiddleRight));
            headerRow.Cells.Add(CreateTableCell("Total", 80, TextAlignment.MiddleRight));
            table.Rows.Add(headerRow);

            // Lignes de données
            foreach (var ligne in lignes)
            {
                var row = new XRTableRow();
                row.Cells.Add(CreateTableCell(ligne.CodeArticle?.ToString() ?? "-", 80));
                row.Cells.Add(CreateTableCell(ligne.Designation ?? "", 200));
                row.Cells.Add(CreateTableCell(ligne.Quantite.ToString(), 60, TextAlignment.MiddleRight));
                row.Cells.Add(CreateTableCell(ligne.PrixUnitaireHT.ToString("N2"), 80, TextAlignment.MiddleRight));
                row.Cells.Add(CreateTableCell((ligne.TauxTVA).ToString("N0") + "%", 60, TextAlignment.MiddleRight));
                row.Cells.Add(CreateTableCell(ligne.PrixUnitaireTTC.ToString("N2"), 80, TextAlignment.MiddleRight));
                row.Cells.Add(CreateTableCell(ligne.Total?.ToString("N2") ?? "0.00", 80, TextAlignment.MiddleRight));
                table.Rows.Add(row);
            }

            return table;
        }

        private XRTableCell CreateTableCell(string text, int width, TextAlignment alignment = TextAlignment.MiddleLeft)
        {
            return new XRTableCell
            {
                Text = text,
                Width = width,
                TextAlignment = alignment,
                Padding = new PaddingInfo(2, 2, 0, 0, 100f),
                Font = new Font("Arial", 9)
            };
        }

        private XRTableCell CreateTotalCell(string text, int width, TextAlignment alignment)
        {
            return new XRTableCell
            {
                Text = text,
                Width = width,
                TextAlignment = alignment,
                Padding = new PaddingInfo(2, 5, 0, 0, 100f),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
        }
    }
}