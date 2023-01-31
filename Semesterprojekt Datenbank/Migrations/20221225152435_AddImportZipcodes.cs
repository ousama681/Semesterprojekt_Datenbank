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

        const string OUSAMA_CONNECTION = "Server=DESKTOP-PMVN625; Database=SemesterarbeitDBS; Trusted_Connection=true; Encrypt=false;";
        const string Leandro_Connection = "Server=LEANDROPAJE1C16\\ZBWMSSQL; Database=SemesterarbeitDBS; Trusted_Connection=true; Encrypt=false;";
        const string BigBoss = "Server=DESKTOP-1470VE0\\ZBW; Database=SemesterarbeitDBS; Trusted_Connection=true; Encrypt=false;";
        const string KimPc = "Server=Koneko\\KONEKO; Database=SemesterarbeitDBS; Trusted_Connection=true; Encrypt=false;";

        const string leandro = "Server=LAMAKUMBAWIN\\LEOSQLSERVER; Database=SemesterarbeitDBS; Trusted_Connection=true; Encrypt=false;";

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var lineNumber = 0;

            using (var connection = new SqlConnection())
            {
                connection.ConnectionString = DataContext.OUSAMA_LP;
                SqlCommand cmd = new SqlCommand();
                connection.Open();

                // using (StreamReader reader = new StreamReader(@"C:\Users\Koneko\source\repos\Semesterprojekt_Datenbank\Semesterprojekt Datenbank\plz_verzeichnis_new (1).csv"))


                //using (StreamReader reader = new StreamReader(@"C:\Users\lamakumba\source\repos\Semesterprojekt_Datenbank\Semesterprojekt Datenbank\plz_verzeichnis_new (1).csv"))   

                using (StreamReader reader = new StreamReader(@"C:\ZbWworkspace\ZbWProjects\DatenbankAdvancedI\SemesterprojektDBS\Semesterprojekt Datenbank\plz_verzeichnis_new (1).csv"))   
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
