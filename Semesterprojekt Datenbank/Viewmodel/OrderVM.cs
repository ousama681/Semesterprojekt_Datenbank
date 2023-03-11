using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class OrderVM
    {
        public static List<OrderVM> OrderList = new List<OrderVM>();
        public List<Position> positionList = new List<Position>();
        private DBUtilityOrder db = new DBUtilityOrder();           
        public string customerName { get; set; }
        public string orderNr { get; set; }
        public int positionNr { get; set; }
        public bool isInvoiceGenerated { get; set; }
        public DateTime orderDate { get; set; }
        public OrderVM()
        {

        }

        public OrderVM(int positionNr)
        {
            this.positionNr = positionNr;
        }
        public OrderVM(List<Position> positionList, string customerName, int orderNr, DateTime orderDate)
        {
            this.positionList = positionList;
            this.customerName = customerName;
            this.positionNr = positionNr;
            this.orderDate = orderDate;
        }

        public bool CreateOrder(OrderVM orderVm)
        {
            return db.Create(orderVm);
        }

        public List<string> GetCustomerNames()
        {
            return db.ReadCustomerNames();
        }

        public List<string> GetArticles()
        {
            return db.ReadArticles();
        }
    }
}
