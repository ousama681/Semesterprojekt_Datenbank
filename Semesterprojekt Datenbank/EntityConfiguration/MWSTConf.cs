using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using System;

namespace Semesterprojekt_Datenbank.EntityConfiguration
{
    public class MWSTConf : IEntityConfiguration
    {
        public void Visit(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MWST>()
                .Property(m => m.TaxValue)
                .IsRequired();
        }
    }
}
