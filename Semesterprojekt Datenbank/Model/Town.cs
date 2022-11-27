using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class Town
    {
        public int Id { get; set; }
        public string ZipCode { get; set; }
        public string City  { get; set; }
        public string Country { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
