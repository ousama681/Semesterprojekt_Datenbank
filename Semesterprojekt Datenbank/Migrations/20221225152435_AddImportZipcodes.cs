﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data;
using System.IO;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AddImportZipcodes : Migration
    {
        /// <inheritdoc />

        const string OUSAMA_CONNECTION = "Server=DESKTOP-PMVN625; Database=DBAProject; Trusted_Connection=true; Encrypt=false;";
        const string Leandro_Connection = "Server=LEANDROPAJE1C16\\ZBWMSSQL; Database=SemesterarbeitDBS; Trusted_Connection=true; Encrypt=false;";
        const string BigBoss = "Server=DESKTOP-1470VE0\\ZBW; Database=SemesterarbeitDBS; Trusted_Connection=true; Encrypt=false;";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var lineNumber = 0;

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = OUSAMA_CONNECTION;
                SqlCommand cmd = new SqlCommand();
                connection.Open();

                using (StreamReader reader = new StreamReader(@"C:\ZbwTechniker\DatenbankenAdvanced\plz_verzeichnis_new.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (lineNumber != 0)
                        {

                            var values = line.Split(";");
                            var zipcode = values[0];
                            var city = values[1];

                            var sql = "INSERT INTO dbo.Town(Zipcode, City, Country)" +
                                      "VALUES" +
                                      $"({values[0]}, '{values[1].Replace("'", "´")}' , 'CH')";

                            cmd.CommandText = sql;
                            cmd.CommandType = CommandType.Text;
                            cmd.Connection = connection;
                            cmd.ExecuteNonQuery();
                        }

                        lineNumber++;
                    }
                }
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}