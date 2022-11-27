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
    public class ArticleConf : DbContext, IEntityConfiguration
    {

        public void Visit(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().Property(a => a.Name).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.Nr).IsRequired();
            modelBuilder.Entity<Article>().Property(a => a.Price).IsRequired();
            

        }
    }
}
