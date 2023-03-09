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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
