using System.Configuration;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data;
using System.IO;
using Semesterprojekt_Datenbank;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AddImportZipcodes : Migration
    {
        /// <inheritdoc />

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var lineNumber = 0;

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = DataContext.GetConnectionStringByName("connection");

                SqlCommand cmd = new SqlCommand();
                connection.Open();

                using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["PathZipCodes"]))
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
