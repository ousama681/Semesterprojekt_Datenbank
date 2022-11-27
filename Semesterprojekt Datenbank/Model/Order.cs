using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Customer CustomerId { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

    }
}
