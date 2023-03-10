using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AddValuesToTheDateColumnInArticle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // TestingData for Articles in ArticleGroup Audio
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('Onkyo TX-NR6100', 18701693, 680, 3, 1, '2021-03-05')," +
                                 "('Philips AZB798T/12', 5706598, 680, 3, 1, '2021-08-25')," +
                                 "('Philips TAR5505', 13389262, 69.80, 3, 1, '2022-02-12')" +
                                 ";");


            // TestingData for Articles in ArticleGroup Audio Zubehör + Ersatzteile
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('Cambridge Audio AXC35', 11291462, 358, 4, 1, '2023-05-07')," +
                                 "('Bose Cushion Kit QuietComfort 35', 8270154, 49, 4, 1, '2021-05-18')," +
                                 "('Sandberg Bluetooth Audio Link 2in1 TxRx', 20709163, 35.30, 4 , 1,  '2022-03-20')" +
                                 ";");

            // TestingData for Articles in ArticleGroup Car HiFi
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('Pioneer SPH-DA360DAB', 21734230, 369, 5, 1, '2023-07-29')," +
                                 "('Blaupunkt Bremen SQR 46 DAB', 11231189, 392, 5, 1, '2021-10-16')," +
                                 "('Pure Highway 600', 6212562, 62.60, 5, 1, '2022-10-01')" +
                                 ";");

            // TestingData for Articles in ArticleGroup DJ
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('Hercules DJ Learning Kit', 12795103, 187, 6, 1,  '2022-12-15')," +
                                 "('Pioneer DJ DDJ-REV1', 18490189, 318, 6, 1, '2021-11-28')," +
                                 "('Razer Audio Mixer', 19976690, 227, 6, 1,  '2023-02-24')" +
                                 ";");

            // TestingData for Articles in ArticleGroup Gehäuse
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('Lian-Li PC-O11DX', 8393857, 159, 7, 1, '2021-07-13')," +
                                 "('be quiet! Pure Base', 13168983, 109, 7, 1, '2022-04-05')," +
                                 "('NZXT H7 CM-H71FB-01', 21020148, 149, 7, 1,  '2022-11-22')" +
                                 ";");

            // TestingData for Articles in ArticleGroup RAM
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('Corsair Vengeance RGB Pro', 12513501, 114, 11, 1, '2021-09-02')," +
                                 "('G.Skill Trident Z5 NEO RGB', 22433066, 325, 11, 1, '2022-09-18')," +
                                 "('Kingston FURY Beast', 18014221, 189, 11, 1,  '2023-12-02')" +
                                 ";");

            // TestingData for Articles in ArticleGroup Grafikkarte
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('ASUS GeForce ROG STRIX RTX 3070 Ti', 16001074, 755, 8, 1, '2023-08-08')," +
                                 "('Sapphire AMD RADEON RX 7900 XT MBA', 23484990, 1039, 8, 1, '2021-12-07')," +
                                 "('KFA2 RTX4090 SG OC', 22706103, 2099, 8, 1, '2022-06-03')" +
                                 ";");

            // TestingData for Articles in ArticleGroup MainBoard
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid, DateTime)" +
                                 "VALUES" +
                                 "('ASUS Prime Z790-P', 22514027, 284, 9, 1, '2021-01-30')," +
                                 "('ASUS ROG CROSSHAIR VIII DARK HERO', 14168846, 353, 9, 1,  '2023-06-14')," +
                                 "('ASUS ROG Strix B550-F Gaming Wifi II', 17442536, 191, 9, 1, '2023-10-12')" +
                                  ";");


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
                "('2021-05-30',2, 0),"+ 
                "('2022-04-18',5, 0),"+
                "('2022-01-21',1, 0),"+
                "('2021-06-02',3, 0),"+
                "('2023-02-01',5, 0),"+
                "('2021-09-14',2, 0),"+
                "('2022-11-28',4, 0),"+
                "('2022-08-05',1, 0),"+
                "('2021-10-19',3, 0),"+
                "('2022-07-07',5, 0),"+
                "('2021-02-14',4, 0),"+
                "('2023-01-05',2, 0),"+
                "('2021-12-30',1, 0),"+
                "('2022-02-14',3, 0),"+
                "('2021-03-22',5, 0),"+
                "('2022-06-07',4, 0),"+
                "('2021-11-19',2, 0),"+
                "('2022-10-16',3, 0),"+
                "('2022-05-09',1, 0),"+
                "('2023-02-09',5, 0),"+
                "('2021-08-25',4, 0),"+
                "('2022-01-02',2, 0),"+
                "('2021-02-27',1, 0),"+
                "('2022-09-22',3, 0),"+
                "('2021-06-11',5, 0),"+
                "('2023-01-27',4, 0),"+
                "('2021-12-08',2, 0),"+
                "('2022-07-01',3, 0),"+
                "('2022-03-26',1, 0),"+
                "('2021-09-03',5, 0),"+
                "('2022-05-22',4, 0),"+
                "('2021-04-03',2, 0),"+
                "('2022-11-11',1, 0),"+
                "('2021-08-16',3, 0),"+
                "('2022-01-31',5, 0),"+
                "('2021-11-02',4, 0),"+
                "('2023-02-21',2, 0),"+
                "('2021-07-14',1, 0),"+
                "('2022-04-07',3, 0);");


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
