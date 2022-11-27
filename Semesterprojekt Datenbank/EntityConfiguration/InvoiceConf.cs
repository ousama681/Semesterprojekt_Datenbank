using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.EntityConfiguration
{
    public class InvoiceConf : IEntityConfiguration
    {
        public void Visit(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Invoice>().Property(a => a.Id).IsRequired();
            modelBuilder.Entity<Invoice>().Property(a => a.Date).IsRequired();
            modelBuilder.Entity<Invoice>().Property(a => a.TotalNetto).IsRequired();
            modelBuilder.Entity<Invoice>().Property(a => a.TotalBrutto).IsRequired();
            modelBuilder.Entity<Invoice>().Property(a => a.CustomerId).IsRequired();
            modelBuilder.Entity<Invoice>().Property(a => a.OrderId).IsRequired();
            modelBuilder.Entity<Invoice>().Property(a => a.TownId).IsRequired();

            modelBuilder.Entity<Invoice>().HasOne(c => c.Customer).WithMany(i => i.Invoices).HasForeignKey(c => c.CustomerId);
            
        }
    }
}
