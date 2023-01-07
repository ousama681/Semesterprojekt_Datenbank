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
            migrationBuilder.Sql("INSERT INTO dbo.ArticleGroup(Name, ParentName)" +
                                 "VALUES" +
                                 "('Audio Player', 'Audio')," +
                                 "('Audio Zubehör + Ersatzteile', 'Audio')," +
                                 "('Car HiFi', 'Audio')," +
                                 "('DJ', 'Audio')," +
                                 "('Audio', 'none')" +
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
