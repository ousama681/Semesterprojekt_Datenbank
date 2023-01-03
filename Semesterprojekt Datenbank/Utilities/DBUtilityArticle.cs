using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Semesterprojekt_Datenbank.Interfaces;

namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityArticle : IDBUtility<ArticleVm>
    {
        ModelBuilder modelBuilder = new ModelBuilder();

        public void Create(ArticleVm customerVm)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ArticleVm item)
        {
            throw new NotImplementedException();
        }

        public List<ArticleVm> Read()
        {
            throw new NotImplementedException();
        }

        public ArticleVm ReadSingle(ArticleVm customerVm)
        {
            throw new NotImplementedException();
        }

        public void Update(ArticleVm item)
        {
            throw new NotImplementedException();
        }
    }
}
