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
            modelBuilder.Entity<Invoice>().Property(a => a.Date);
            modelBuilder.Entity<Invoice>().Property(a => a.NetPrice);
            modelBuilder.Entity<Invoice>().Property(a => a.OrderId).IsRequired();

            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Order)
                .WithOne(o => o.Invoice)
                .HasForeignKey<Invoice>(i => i.OrderId);
        }
    }
}
