using Semesterprojekt_Datenbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semesterprojekt_Datenbank.Utilities;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class ArticleVm
    {
        public static List<ArticleVm> ArticleList { get; set; } = new List<ArticleVm>();
        private DBUtilityArticle dB = new DBUtilityArticle();

        public string Name { get; set; }
        public int Nr { get; set; }
        public decimal Price { get; set; }
        public string ArticleGroup { get; set; }

        public ArticleVm()
        {

        }
        public ArticleVm(string name, int nr, decimal price, string articleGroup)
        {
            Name = name;
            Nr = nr;
            Price = price;
            ArticleGroup = articleGroup;
        }

        public void CreateArticle(ArticleVm articleVm)
        {
            dB.Create(articleVm);
        }
        public void UpdateArticle(ArticleVm articleVm)
        {
            var outputDbArticle = dB.ReadSingle(articleVm);

            if (!outputDbArticle.Equals(articleVm))
            {
                dB.Update(articleVm);
            }
        }

        public bool DeleteArticle(ArticleVm articleVm)
        {
            return dB.Delete(articleVm);
        }



    }
}
