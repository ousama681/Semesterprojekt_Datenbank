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
    public class ArticleGroupConf : IEntityConfiguration
    {
        public void Visit(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArticleGroup>().Property(a => a.Name).IsRequired();
            modelBuilder.Entity<ArticleGroup>().Property(a => a.ParentId);
        }
    }
}
