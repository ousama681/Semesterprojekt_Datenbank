using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Nr { get; set; }
        public decimal Price { get; set; }
        public int ArticleGroupId { get; set; }
        public virtual ArticleGroup ArticleGroup { get; set; }
        

    }
}
