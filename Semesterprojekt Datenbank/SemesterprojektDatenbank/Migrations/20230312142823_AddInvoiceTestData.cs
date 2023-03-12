using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Runtime.InteropServices;

#nullable disable

namespace SemesterprojektDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AddInvoiceTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO INVOICE(Date, NetPrice, OrderId, CustomerId)" +
                                 "VALUES" +
                                 "('2023-01-01', 4543.21, 5, 5)," +
                                 "('2023-01-01', 1802.45, 8, 1)," +
                                 "('2023-01-01', 7333.32, 18, 3)," +
                                 "('2023-01-01', 4876.53, 23, 1)," +
                                 "('2023-01-01', 567.89, 29, 1)," +
                                 "('2023-01-01', 2100.00, 28, 3)," +
                                 "('2023-01-01', 100.00, 25, 5)," +
                                 "('2023-01-01', 1334.56, 26, 4)," +
                                 "('2023-01-01', 800.00, 19, 1)," +
                                 "('2023-01-01', 2000.00, 17, 2)," +
                                 "('2023-01-01', 2678.90, 15, 5)," +
                                 "('2023-01-01', 1234.56, 27, 2)," +
                                 "('2023-01-01', 1543.21, 32, 2)," +
                                 "('2023-01-01', 2999.99, 36, 4)," +
                                 "('2023-01-01', 2500.00, 31, 4)"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM INVOICE;");
        }
    }
}
