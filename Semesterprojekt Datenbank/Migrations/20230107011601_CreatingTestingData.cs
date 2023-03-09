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
                                 "('PC Komponenten', null)," +
                                 "('Audio', null)," +
                                 "('Audio Player', 2)," +
                                 "('Audio Zubehör + Ersatzteile', 2)," +
                                 "('Car HiFi', 2)," +
                                 "('DJ', 2)," +
                                 "('Gehäuse', 1)," +
                                 "('Grafikkarte', 1)," +
                                 "('Mainboard', 1)," +
                                 "('Prozessor', 1)," +
                                 "('RAM', 1)" +
                                 ";");


            // TestingData for MWST
            migrationBuilder.Sql("INSERT INTO dbo.MWST(TaxValue)" +
                                 "VALUES" +
                                 "(7.7)," +
                                 "(2.5)," +
                                 "(3.7)" +
                                 ";");


            // TestingData for Customers
            migrationBuilder.Sql("INSERT INTO dbo.Customer(Nr, Name, Email, Website, Password, Street, TownId)" +
                                 "VALUES" +
                                 "(5001, 'Herbert AG', 'herbert@werkstatt.ch', 'herbertag.ch', 'herbertGutesPw', 'Wilerstrasse 12', 112)," +
                                 "(5002, 'Starrag AG', 'starrag@rorschach.ch', 'starrag.ch', 'WirBauenMaschinen', 'Seestrasse 44', 442)," +
                                 "(5003, 'McDonalds GmbH', 'mcdonalds@imlovinit.com', 'mcdonalds.com', 'UnserEssenSchmecktScheisse', 'Stadtstrasse 34', 200)," +
                                 "(5004, 'Eiko GmbH', 'eiko@stgallen.ch', 'eiko.ch', 'SehrGutesPW', 'St-Fidenstrasse 11', 155)," +
                                 "(5005, 'Bamboo GmbH', 'bamboo@food.ch', 'bamboo.ch', 'WeSellRice!', 'Bahnhofsstrasse 15',111)" +
                                 ";");




        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
