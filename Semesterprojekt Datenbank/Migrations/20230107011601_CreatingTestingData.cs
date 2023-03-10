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

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
