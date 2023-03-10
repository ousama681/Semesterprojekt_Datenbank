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
    public class TownConf : IEntityConfiguration
    {
        public void Visit(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Town>().Property(a => a.Id).IsRequired();
            modelBuilder.Entity<Town>().Property(a => a.ZipCode).IsRequired();
            modelBuilder.Entity<Town>().Property(a => a.City).IsRequired();
            modelBuilder.Entity<Town>().Property(a => a.Country).IsRequired();

            modelBuilder.Entity<Town>().HasMany(t => t.Customers).WithOne(c => c.Town).HasForeignKey(c => c.TownId);
        }
    }
}
