using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal NetPrice { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
