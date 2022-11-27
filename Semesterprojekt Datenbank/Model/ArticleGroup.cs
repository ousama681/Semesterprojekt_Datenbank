using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class ArticleGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
