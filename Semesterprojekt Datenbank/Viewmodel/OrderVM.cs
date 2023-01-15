using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class OrderVM
    {
        public static List<OrderVM> OrderList = new List<OrderVM>();

        public List<OrderVM> PositionList = new List<OrderVM>();
        public string customerName { get; set; }
        public string articleName { get; set; }
        public int quantity { get; set;  }
        public string orderNr { get; set; }
        public int positionNr { get; set; }
        public DateTime orderDate { get; set; }

        public OrderVM()
        {

        }

        public OrderVM(int positionNr, string articleName, int quantity)
        {
            this.positionNr = positionNr;
            this.articleName = articleName;
            this.quantity = quantity;
        }
        public OrderVM(List<OrderVM> positionList, string customerName, string articleName, int quantity, string orderNr, int positionNr, DateTime orderDate)
        {
            PositionList = positionList;
            this.customerName = customerName;
            this.articleName = articleName;
            this.quantity = quantity;
            this.orderNr = orderNr;
            this.positionNr = positionNr;
            this.orderDate = orderDate;
        }

        public string GetPosition()
        {
            return "Pos Nr: " + positionNr + "   |   Artikel: " + articleName + "   |   Anzahl: " + quantity;
        }
        public void CreateOrder(OrderVM orderVm)
        {

        }




    }
}
