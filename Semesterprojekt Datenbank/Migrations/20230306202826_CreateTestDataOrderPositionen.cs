using Microsoft.EntityFrameworkCore.Migrations;
using Semesterprojekt_Datenbank.Model;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class CreateTestDataOrderPositionen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropColumn(
                name: "PriceBrutto",
                table: "Position");

            migrationBuilder.Sql(
                "INSERT INTO[dbo].[Customer]" +
                "(Nr, Name, Email, Website, Password, Street, TownId)" +
                "VALUES" +
                "(5001, 'Herbert AG', 'herbert@werkstatt.ch', 'herbertag.ch', 'herbertGutesPw', 'Wilerstrasse 12', 112)," +
                "(5002, 'Starrag AG', 'starrag@rorschach.ch', 'starrag.ch', 'WirBauenMaschinen', 'Seestrasse 44', 442)," +
                "(5003, 'McDonalds GmbH', 'mcdonalds@imlovinit.com', 'mcdonalds.com', 'UnserEssenSchmecktScheisse', 'Stadtstrasse 34', 200)," +
                "(5004, 'Eiko GmbH', 'eiko@stgallen.ch', 'eiko.ch', 'SehrGutesPW', 'St-Fidenstrasse 11', 155)," +
                "(5005, 'Bamboo GmbH', 'bamboo@food.ch', 'bamboo.ch', 'WeSellRice!', 'Bahnhofsstrasse 15', 111)"
            );

            migrationBuilder.Sql(
                "INSERT INTO [Order](Date, CustomerId, isInvoiceGenerated)" +
                "VALUES" +
                "('2022-01-01', 1, 0)," +
                "('2022-01-02', 2, 0)," +
                "('2022-01-03', 3, 0)," +
                "('2022-01-04', 4, 0)," +
                "('2022-01-05', 5, 0)," +
                "('2022-01-06', 1, 0)," +
                "('2022-01-07', 2, 0)," +
                "('2022-01-08', 3, 0)," +
                "('2022-01-09', 4, 0)," +
                "('2022-01-10', 5, 0)," +
                "('2022-01-11', 1, 0)," +
                "('2022-01-12', 2, 0)," +
                "('2022-01-13', 3, 0)," +
                "('2022-01-14', 4, 0)," +
                "('2022-01-15', 5, 0)," +
                "('2022-01-16', 1, 0)," +
                "('2022-01-17', 2, 0)," +
                "('2022-01-18', 3, 0)," +
                "('2022-01-19', 4, 0)," +
                "('2022-01-20', 5, 0)," +
                "('2022-01-21', 1, 0)," +
                "('2022-01-22', 2, 0)," +
                "('2022-01-23', 3, 0)," +
                "('2022-01-24', 4, 0)," +
                "('2022-01-25', 5, 0)," +
                "('2022-01-26', 1, 0)," +
                "('2022-01-27', 2, 0)," +
                "('2022-01-28', 3, 0)," +
                "('2022-01-29', 4, 0)," +
                "('2022-01-30', 5, 0)," +
                "('2022-01-31', 1, 0)," +
                "('2022-02-01', 2, 0)," +
                "('2022-02-02', 3, 0)," +
                "('2022-02-03', 4, 0)," +
                "('2022-02-04', 5, 0)," +
                "('2022-02-05', 1, 0)," +
                "('2022-02-06', 2, 0)," +
                "('2022-02-07', 3, 0)," +
                "('2022-02-08', 4, 0)," +
                "('2022-02-09', 5, 0)," +
                "('2022-02-10', 1, 0)," +
                "('2022-02-11', 2, 0)," +
                "('2022-02-12', 3, 0)," +
                "('2022-02-13', 4, 0)," +
                "('2022-02-14', 5, 0)," +
                "('2022-02-15', 1, 0)," +
                "('2022-02-16', 2, 0)," +
                "('2022-02-17', 3, 0)," +
                "('2022-02-18', 4, 0)," +
                "('2022-02-19', 5, 0)," +
                "('2022-02-20', 1, 0);"
                );

            migrationBuilder.Sql(
            "INSERT INTO POSITION(Quantity, PriceNetto, ArticleId, OrderId)" +
            "VALUES" +
            "(4, 2345.67, 18, 23)," +
            "(5, 987.65, 6, 34)," +
            "(9, 1543.21, 3, 2)," +
            "(3, 1234.56, 9, 7)," +
            "(8, 2678.90, 21, 15)," +
            "(1, 432.10, 16, 43)," +
            "(2, 2100.00, 12, 28)," +
            "(7, 876.54, 4, 49)," +
            "(6, 1789.01, 11, 11)," +
            "(10, 2999.99, 23, 36)," +
            "(3, 567.89, 20, 29)," +
            "(8, 1234.56, 5, 8)," +
            "(5, 2500.00, 17, 16)," +
            "(2, 3000.00, 1, 1)," +
            "(4, 800.00, 14, 44)," +
            "(6, 1987.65, 2, 6)," +
            "(1, 100.00, 24, 25)," +
            "(9, 1500.00, 22, 22)," +
            "(10, 2900.00, 19, 21)," +
            "(7, 987.65, 8, 47)," +
            "(3, 1234.56, 10, 4)," +
            "(5, 1200.00, 7, 33)," +
            "(8, 2345.67, 13, 18)," +
            "(1, 100.00, 15, 10)," +
            "(6, 1987.65, 6, 12)," +
            "(2, 2000.00, 16, 17)," +
            "(4, 1543.21, 3, 38)," +
            "(9, 2900.00, 23, 14)," +
            "(10, 2500.00, 18, 31)," +
            "(5, 800.00, 21, 19)," +
            "(3, 567.89, 4, 39)," +
            "(8, 1234.56, 9, 27)," +
            "(6, 2100.00, 12, 42)," +
            "(2, 3000.00, 1, 5)," +
            "(4, 1543.21, 13, 32)," +
            "(7, 1200.00, 22, 41)," +
            "(9, 2900.00, 19, 30)," +
            "(10, 2500.00, 17, 46)," +
            "(5, 800.00, 8, 35)," +
            "(3, 567.89, 20, 24)," +
            "(1, 100.00, 24, 26)," +
            "(8, 1234.56, 15, 37)," +
            "(6, 2100.00, 14, 45);"
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<decimal>(
                name: "PriceBrutto",
                table: "Position",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
