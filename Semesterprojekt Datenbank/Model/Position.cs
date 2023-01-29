using Syncfusion.Windows.Forms.Tools;
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
        public int PositionNr { get; set; }
        public int Quantity { get; set; }
        public decimal PriceNetto { get; set; }
        public decimal PriceBrutto { get; set; }
        public int ArticleId { get; set; }
        public int OrderId { get; set; }
        public virtual Article Article { get; set; }
        public virtual Order Order { get; set; }

        public Position(int positionNr, int quantity, decimal priceNetto, decimal priceBrutto, int articleId, int orderId)
        {
            PositionNr = positionNr;
            Quantity = quantity;
            PriceNetto = priceNetto;
            PriceBrutto = priceBrutto;
            ArticleId = articleId;
            OrderId = orderId;
        }

        public Position()
        {

        }

        public string PositionToString()
        {
            return "Pos Nr: " + PositionNr + "   |   Artikel: " + Article.Name + "   |   Anzahl: " + Quantity;
        }
    }
}
