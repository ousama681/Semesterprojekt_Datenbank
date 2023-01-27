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
        public int ArticleId { get; set; }
        public int OrderId { get; set; }
        public virtual Article Article { get; set; }
        public virtual Order Order { get; set; }

        public Position(int quantity, decimal priceNetto, decimal priceBrutto, int articleId, int orderId)
        {
            Quantity = quantity;
            PriceNetto = priceNetto;
            PriceBrutto = priceBrutto;
            ArticleId = articleId;
            OrderId = orderId;
        }

        public Position()
        {

        }
    }
}
