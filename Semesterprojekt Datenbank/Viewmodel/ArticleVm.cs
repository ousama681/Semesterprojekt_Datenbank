using Semesterprojekt_Datenbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class ArticleVm
    {
        public static List<Article> ArticleList { get; set; } = new List<Article>();

        public string Name { get; set; }
        public int Nr { get; set; }
        public decimal Price { get; set; }



    }
}
