using Microsoft.EntityFrameworkCore.Migrations;
using Semesterprojekt_Datenbank.Model;
using System.Collections.Concurrent;
using System.Windows.Forms;
using System;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AddViewsForJahresvergleich : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // -- VIEW erstellen für Kategorie Anzahl Aufträge 
            migrationBuilder.Sql(
                "CREATE VIEW view_AnzahlAuftraege AS " +
                "SELECT count(t.AnzahlAuftraege) as AnzahlAuftraege, " +
                "t.JahrQuartal, " +
                "t.YOY " +
                "FROM (SELECT count(i.Id) OVER (PARTITION BY YEAR(o.Date), " +
                "DATEPART(QUARTER, o.Date)) as AnzahlAuftraege, " +
                "count(i.Id) OVER() as YOY, " +
                "CONCAT(CAST(YEAR(o.Date) AS varchar), '_', 'Q', CAST(DATEPART(QUARTER, o.Date) AS varchar)) AS JahrQuartal " +
                "FROM Invoice as i JOIN [Order] as o on (i.OrderId = o.Id)) as t " +
                "GROUP BY t.JahrQuartal, t.YOY;");

            // -- VIEW erstellen für anzahl verwaltete Artikel
            migrationBuilder.Sql(
                "CREATE VIEW view_AnzahlVerwalteteArtikel AS " +
                "SELECT count(subA.AnzahlArtikel) as AnzahlArtikel, subA.JahrQuartal as JahrQuartal, subA.YOY as YOY " +
                "FROM " +
                "(SELECT count(a.Id) OVER(PARTITION BY YEAR(a.DateTime), DATEPART(QUARTER, a.Datetime)) as AnzahlArtikel, " +
                "CONCAT(CAST(YEAR(a.[DateTime]) AS varchar), '_', 'Q', CAST(DATEPART(QUARTER, a.[DateTime]) AS varchar)) AS JahrQuartal, " +
                "count(a.Id) OVER() as YOY " +
                "FROM Article as a) as subA " +
                "GROUP BY suba.JahrQuartal, subA.YOY;");

            // -- VIEW erstellen für GesamtUmsatz Pro Kunde
            migrationBuilder.Sql(
                "CREATE VIEW view_GesamtumsatzProKunde AS " +
                "( " +
                "SELECT YEAR(o.Date) as Jahr, DATEPART(QUARTER, o.Date) as Quartal, sum(p.PriceNetto) as PreisProOrder, c.Name " +
                "FROM Invoice as i JOIN [ORDER] as o ON(o.Id = i.OrderId) " +
                "JOIN [Customer] as c ON (c.Id = o.CustomerId) " +
                "LEFT JOIN Position as p ON (o.Id = p.OrderId) " +
                "LEFT JOIN Article as a ON (p.ArticleId = a.Id) " +
                "GROUP BY YEAR(o.Date), DATEPART(QUARTER, o.Date), c.Name);"
            );

            // Durschnittlicher Bestellwert Pro Kunde im Quartal
            migrationBuilder.Sql("CREATE VIEW view_DurchschBestellWertProKundeQ AS " +
                                 "SELECT t.DurcschGesamtumsatzProKunde as DurchschnGesamtUmsatz, t.JahrQuartal as JahrQuartal, avg(t.DurcschGesamtumsatzProKunde) OVER () as YOY " +
                                 "FROM " +
                                 "(SELECT AVG(PreisProOrder) as DurcschGesamtumsatzProKunde, " +
                                 "CONCAT(CAST(Jahr AS varchar), '_', 'Q', CAST(Quartal AS varchar)) as JahrQuartal " +
                                 "FROM view_GesamtumsatzProKunde " +
                                 "GROUP BY Jahr, Quartal " +
                                 ") as t " +
                                 "GROUP BY t.DurcschGesamtumsatzProKunde, t.JahrQuartal;");

            // VIEW erstellen für Gesamtumsatz 
            migrationBuilder.Sql("CREATE VIEW view_GesamtUmsatzQ AS " +
                                 "SELECT t.Umsatz, t.JahrQuartal, sum(t.Umsatz) OVER() as YOY " +
                                 "FROM ( " +
                                 "SELECT sum(p.PriceNetto) Umsatz, CONCAT(CAST(YEAR(o.Date) AS varchar), '_', 'Q', CAST(DATEPART(QUARTER, o.Date) AS varchar)) AS JahrQuartal " +
                                 "FROM Invoice as i JOIN [ORDER] as o ON(o.Id = i.OrderId) " +
                                 "JOIN [Customer] as c ON (c.Id = o.CustomerId) " +
                                 "LEFT JOIN Position as p ON (o.Id = p.OrderId) " +
                                 "LEFT JOIN Article as a ON (p.ArticleId = a.Id) " +
                                 "GROUP BY  YEAR(o.Date), DATEPART(QUARTER, o.Date)) as t;");

            // VIEW erstellen für view_AverageArtikelProAuftrage
            migrationBuilder.Sql("CREATE VIEW view_AverageArtikelProAuftrag AS " +
                                 "SELECT  t.AverageArtikel, t.JahrQuartal, avg(t.AverageArtikel) OVER () as YOY " +
                                 "FROM " +
                                 "(SELECT avg(t.anzahlArtikelProauftrag) as AverageArtikel, t.JahrQuartal " +
                                 "FROM " +
                                 "(SELECT count(p.Id) OVER(PARTITION BY o.Id) as anzahlArtikelProauftrag, o.Id as OrderId, " +
                                 "CONCAT(CAST(YEAR(o.Date) AS varchar), '_', 'Q', CAST(DATEPART(QUARTER, o.Date) AS varchar)) AS JahrQuartal " +
                                 "FROM Invoice as i JOIN [Order] as o ON(i.OrderId = o.Id) " +
                                 "JOIN Position as p ON(o.Id = p.OrderId)) as t " +
                                 "GROUP BY JahrQuartal) as t;");

            migrationBuilder.Sql("CREATE VIEW view_Jahresvergleich AS " +
                                 "SELECT 'Anzahl Aufträge' as Kategorie ,* " +
                                 "FROM " +
                                 "( " +
                                 "SELECT v.AnzahlAuftraege, v.YOY, v.JahrQuartal " +
                                 "FROM view_AnzahlAuftraege as v " +
                                 ") t " +
                                 "PIVOT ( " +
                                 "sum(AnzahlAuftraege) FOR JahrQuartal IN([2023_Q4], [2023_Q3], [2023_Q2], [2023_Q1], [2022_Q4], [2022_Q3], [2022_Q2], [2022_Q1], [2021_Q4], [2021_Q3], [2021_Q2], [2021_Q1]) " +
                                 ") as pivotTable " +
                                 "UNION " +
                                 "SELECT 'Anzahl verwaltete Artikel' as Kategorie, * " +
                                 "FROM ( " +
                                 "SELECT a.AnzahlArtikel, a.YOY, a.JahrQuartal " +
                                 "FROM view_AnzahlVerwalteteArtikel as a " +
                                 ") t " +
                                 "PIVOT( " +
                                 "sum(AnzahlArtikel) FOR JahrQuartal IN([2023_Q4], [2023_Q3], [2023_Q2], [2023_Q1], [2022_Q4], [2022_Q3], [2022_Q2], [2022_Q1], [2021_Q4], [2021_Q3], [2021_Q2], [2021_Q1]) " +
                                 ") as pivotTable " +
                                 "UNION " +
                                 "SELECT 'Durchschnittliche Anzahl Artikel pro Auftrag' as Kategorie, * " +
                                 "FROM ( " +
                                 "SELECT a.AverageArtikel, a.YOY, a.JahrQuartal " +
                                 "FROM view_AverageArtikelProAuftrag as a " +
                                 ") t " +
                                 "PIVOT( " +
                                 "avg(AverageArtikel) FOR JahrQuartal IN([2023_Q4], [2023_Q3], [2023_Q2], [2023_Q1], [2022_Q4], [2022_Q3], [2022_Q2], [2022_Q1], [2021_Q4], [2021_Q3], [2021_Q2], [2021_Q1]) " +
                                 ") as pivotTable " +
                                 "UNION " +
                                 "SELECT 'Durchschnittlicher Umsatz pro Kunde' as Kategorie, * " +
                                 "FROM ( " +
                                 "SELECT a.DurchschnGesamtUmsatz, a.YOY, a.JahrQuartal " +
                                 "FROM view_DurchschBestellWertProKundeQ as a " +
                                 ") t " +
                                 "PIVOT( " +
                                 "avg(DurchschnGesamtUmsatz) FOR JahrQuartal IN([2023_Q4], [2023_Q3], [2023_Q2], [2023_Q1], [2022_Q4], [2022_Q3], [2022_Q2], [2022_Q1], [2021_Q4], [2021_Q3], [2021_Q2], [2021_Q1]) " +
                                 ") as pivotTable " +
                                 "UNION " +
                                 "SELECT 'Gesamtumsatz' as Kategorie, * " +
                                 "FROM( " +
                                 "SELECT a.Umsatz, a.YOY, a.JahrQuartal " +
                                 "FROM view_GesamtumsatzQ as a " +
                                 ") t " +
                                 "PIVOT(" +
                                 "sum(Umsatz) FOR JahrQuartal IN([2023_Q4], [2023_Q3], [2023_Q2], [2023_Q1], [2022_Q4], [2022_Q3], [2022_Q2], [2022_Q1], [2021_Q4], [2021_Q3], [2021_Q2], [2021_Q1]) " +
                                 ") as pivotTable;"
                                 );



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW view_AnzahlAuftraege;");

            migrationBuilder.Sql("DROP VIEW view_AnzahlVerwalteteArtikel;");

            migrationBuilder.Sql("DROP VIEW view_GesamtumsatzProKunde;");

            migrationBuilder.Sql("DROP VIEW view_DurchschBestellWertProKundeQ;");

            migrationBuilder.Sql("DROP VIEW view_GesamtUmsatzQ;");

            migrationBuilder.Sql("DROP VIEW view_AverageArtikelProAuftrag;");

            migrationBuilder.Sql("DROP VIEW view_Jahresvergleich;");
        }
    }
}


