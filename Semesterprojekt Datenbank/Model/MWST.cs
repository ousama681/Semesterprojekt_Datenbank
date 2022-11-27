using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class MWST
    {
        public int Id { get; set; }
        public double TaxValue { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
}
