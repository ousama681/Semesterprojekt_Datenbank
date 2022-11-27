using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class Position
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PriceNetto { get; set; }
        public decimal PriceBrutto { get; set; }
        public Article ArticleId { get; set; }
        public Order OrderId { get; set; }
    }
}
