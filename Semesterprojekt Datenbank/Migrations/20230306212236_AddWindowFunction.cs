using Microsoft.EntityFrameworkCore.Migrations;
using Semesterprojekt_Datenbank.Model;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AddWindowFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "create Function [dbo].[SalesPerQuarter]() " +
                "returns table " +
                "As " +
                "return " +
                "(" +
                "WITH orders_by_quarter AS(" +
                "SELECT " +
                "DATEPART(Quarter, o.[date]) AS[quarter], " +
                "DATEPART(Year, o.[Date]) AS[year], " +
                "COUNT(DISTINCT o.id) AS num_orders, " +
                "COUNT(DISTINCT p.id) AS num_positions, " +
                "COUNT(DISTINCT a.Id) AS num_articles " +
                "FROM [Order] o " +
                "INNER JOIN Position p ON o.id = p.orderid " +
                "RIGHT JOIN Article a ON p.ArticleId = a.Id " +
                "GROUP BY DATEPART(QUARTER, o.[date]), " +
                "DATEPART(Year, o.[Date]) " +
                ")," +
                "orders_by_category AS( " +
                "    SELECT " +
                "'Anzahl Aufträge' AS Kategorie, " +
                "    SUM(num_orders) AS yoy, " +
                "SUM(CASE WHEN[quarter] = 4 AND[year] = 2023 THEN num_orders ELSE 0 END) AS q4_2023, " +
                "    SUM(CASE WHEN[quarter] = 3 AND[year] = 2023 THEN num_orders ELSE 0 END) AS q3_2023, " +
                "    SUM(CASE WHEN[quarter] = 2 AND[year] = 2023 THEN num_orders ELSE 0 END) AS q2_2023, " +
                "    SUM(CASE WHEN[quarter] = 1 AND[year] = 2023 THEN num_orders ELSE 0 END) AS q1_2023, " +
                "    SUM(CASE WHEN[quarter] = 4 AND[year] = 2022 THEN num_orders ELSE 0 END) AS q4_2022, " +
                "    SUM(CASE WHEN[quarter] = 3 AND[year] = 2022 THEN num_orders ELSE 0 END) AS q3_2022 " +
                "FROM " +
                "    orders_by_quarter " +
                "UNION " +
                "    SELECT 'Anzahl verwaltete Artikel' as Kategorie, " +
                "SUM(num_articles) AS yoy, " +
                "    SUM(CASE WHEN[quarter] = 4 AND[year] = 2023 THEN num_articles ELSE 0 END) AS q4_2023, " +
                "    SUM(CASE WHEN[quarter] = 3 AND[year] = 2023 THEN num_articles ELSE 0 END) AS q3_2023, " +
                "    SUM(CASE WHEN[quarter] = 2 AND[year] = 2023 THEN num_articles ELSE 0 END) AS q2_2023, " +
                "    SUM(CASE WHEN[quarter] = 1 AND[year] = 2023 THEN num_articles ELSE 0 END) AS q1_2023, " +
                "    SUM(CASE WHEN[quarter] = 4 AND[year] = 2022 THEN num_articles ELSE 0 END) AS q4_2022, " +
                "    SUM(CASE WHEN[quarter] = 3 AND[year] = 2022 THEN num_articles     ELSE 0 END) AS q3_2022 " +
                "FROM orders_by_quarter " +
                "UNION " +
                "    SELECT 'Durchschnittliche Anzahl Artikel pro Auftrag', 10, 10, 190, 10, 10, 10, 10 " +
                "UNION " +
                "    SELECT 'Umsatz pro Kunde', 10, 10, 190, 10, 10, 10, 10 " +
                "UNION " +
                "    SELECT 'Gesamtumsatz', 10, 10, 190, 10, 10, 10, 10" +
                ")" +
                "Select * from orders_by_category);"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
