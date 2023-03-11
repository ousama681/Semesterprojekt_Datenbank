using Semesterprojekt_Datenbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semesterprojekt_Datenbank.Utilities;
using System.Windows.Markup;

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
        public DateTime DateTime { get; set; }

        public ArticleVm()
        {

        }
        public ArticleVm(string name, int nr, decimal price, string articleGroup, DateTime dateTime)
        {
            Name = name;
            Nr = nr;
            Price = price;
            ArticleGroup = articleGroup;
            DateTime = dateTime;
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
        public bool isArticleNrUsed(int nr)
        {
            bool nrUsed = false;
            foreach (var vm in ArticleList)
            {
                if (nr == vm.Nr)
                {
                    nrUsed = true;
                    return nrUsed;
                }
            }
            return false;
        }

        public List<string> GetArticleGRoupNames()
        {
            return dB.ReadArticleGroup();
        }
    }
}
