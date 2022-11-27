using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.EntityConfiguration;
using Semesterprojekt_Datenbank.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank
{
    public class DataContext : DbContext
    {
        DbSet<Article> Articles;
        DbSet<ArticleGroup> ArticleGroups;
        DbSet<Customer> Customer;
        DbSet<Invoice> Invoices;
        DbSet<Town> Town;
        DbSet<Order> Orders;
        DbSet<Position> Positions;


        // DESKTOP-1470VE0\ZBW
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DataSource=DESKTOP-1470VE0\\ZBW; Database=DBAProject; Trusted_Connection=true; Encrypt=false;");
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Debug);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}
