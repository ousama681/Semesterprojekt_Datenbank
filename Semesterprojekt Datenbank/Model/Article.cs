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
        public int Mwstid { get; set; }
        public virtual MWST MWST { get; set; }
        public virtual ArticleGroup ArticleGroup { get; set; }

        public DateTime DateTime { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
        
        public Article(string name, int nr, decimal price, int articleGroupId, int mwstid, DateTime dateTime)
        {
            Name = name;
            Nr = nr;
            Price = price;
            ArticleGroupId = articleGroupId;
            Mwstid = mwstid;
            DateTime = dateTime;
        }

        public Article()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
