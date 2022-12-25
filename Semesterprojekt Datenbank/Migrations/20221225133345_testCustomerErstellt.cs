using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class testCustomerErstellt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //--truncate the table first
            //    TRUNCATE TABLE dbo.Actors;
            //GO

            //    -- import the file
            //    BULK INSERT dbo.Actors
            //    FROM 'C:\Documents\Skyvia\csv-to-mssql\actor.csv'
            //WITH
            //(
            //    FORMAT = 'CSV',
            //    FIRSTROW = 2
            //)
            //GO





        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
