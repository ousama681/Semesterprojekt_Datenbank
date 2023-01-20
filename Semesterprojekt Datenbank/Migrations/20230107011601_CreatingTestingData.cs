using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Semesterprojekt_Datenbank;
using Semesterprojekt_Datenbank.Model;
using System.Data;
using System.IO;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class CreatingTestingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // TestingData for ArticleGroup
            migrationBuilder.Sql("INSERT INTO dbo.ArticleGroup(Name, ParentId)" +
                                 "VALUES" +
                                 "('Audio Player', 5)," +
                                 "('Audio Zubehör + Ersatzteile', 5)," +
                                 "('Car HiFi', 5)," +
                                 "('DJ', 5)," +
                                 "('Audio', null)," +
                                 "('Gehäuse', 11)," +
                                 "('Grafikkarte', 11)," +
                                 "('Mainboard', 11)," +
                                 "('Prozessor', 11)," +
                                 "('RAM', 11)," +
                                 "('PC Komponenten', null)" +
                                 ";");


            // TestingData for MWST
            migrationBuilder.Sql("INSERT INTO dbo.MWST(TaxValue)" +
                                 "VALUES" +
                                 "(7.7)," +
                                 "(2.5)," +
                                 "(3.7)" +
                                 ";");


            // TestingData for Articles in ArticleGroup Audio
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('Onkyo TX-NR6100', 18701693, 680, 1, 1)," +
                                 "('Philips AZB798T/12', 5706598, 680, 1, 1)," +
                                 "('Philips TAR5505', 13389262, 69.80, 1, 1)" +
                                 ";");


            // TestingData for Articles in ArticleGroup Audio Zubehör + Ersatzteile
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('Cambridge Audio AXC35', 11291462, 358, 2, 1)," +
                                 "('Bose Cushion Kit QuietComfort 35', 8270154, 49, 2, 1)," +
                                 "('Sandberg Bluetooth Audio Link 2in1 TxRx', 20709163, 35.30, 2 , 1)" +
                                 ";");

            // TestingData for Articles in ArticleGroup Car HiFi
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('Pioneer SPH-DA360DAB', 21734230, 369, 3, 1)," +
                                 "('Blaupunkt Bremen SQR 46 DAB', 11231189, 392, 3, 1)," +
                                 "('Pure Highway 600', 6212562, 62.60, 3, 1)" +
                                 ";");

            // TestingData for Articles in ArticleGroup DJ
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('Hercules DJ Learning Kit', 12795103, 187, 4, 1)," +
                                 "('Pioneer DJ DDJ-REV1', 18490189, 318, 4, 1)," +
                                 "('Razer Audio Mixer', 19976690, 227, 4, 1)" +
                                 ";");

            // TestingData for Articles in ArticleGroup Gehäuse
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('Lian-Li PC-O11DX', 8393857, 159, 6, 1)," +
                                 "('be quiet! Pure Base', 13168983, 109, 6, 1)," +
                                 "('NZXT H7 CM-H71FB-01', 21020148, 149, 6, 1)" +
                                 ";");

            // TestingData for Articles in ArticleGroup RAM
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('Corsair Vengeance RGB Pro', 12513501, 114, 10, 1)," +
                                 "('G.Skill Trident Z5 NEO RGB', 22433066, 325, 10, 1)," +
                                 "('Kingston FURY Beast', 18014221, 189, 10, 1)" +
                                 ";");

            // TestingData for Articles in ArticleGroup Grafikkarte
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('ASUS GeForce ROG STRIX RTX 3070 Ti', 16001074, 755, 7, 1)," +
                                 "('Sapphire AMD RADEON RX 7900 XT MBA', 23484990, 1039, 7, 1)," +
                                 "('KFA2 RTX4090 SG OC', 22706103, 2099, 7, 1)" +
                                 ";");

            // TestingData for Articles in ArticleGroup MainBoard
            migrationBuilder.Sql("INSERT INTO dbo.Article(Name, Nr, Price, ArticleGroupId, Mwstid)" +
                                 "VALUES" +
                                 "('ASUS Prime Z790-P', 22514027, 284, 8, 1)," +
                                 "('ASUS ROG CROSSHAIR VIII DARK HERO', 14168846, 353, 8, 1)," +
                                 "('ASUS ROG Strix B550-F Gaming Wifi II', 17442536, 191, 8, 1)" +
                                  ";");




        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
