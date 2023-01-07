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
            migrationBuilder.Sql("INSERT INTO dbo.ArticleGroup(Name, ParentName)" +
                                 "VALUES" +
                                 "('Audio Player', 'Audio')," +
                                 "('Audio Zubehör + Ersatzteile', 'Audio')," +
                                 "('Car HiFi', 'Audio')," +
                                 "('DJ', 'Audio')" +
                                 ";");

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
