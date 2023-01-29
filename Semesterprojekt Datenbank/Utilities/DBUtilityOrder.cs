using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;

namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityOrder : IDBUtility<OrderVM>
    {
        ModelBuilder modelBuilder = new ModelBuilder();

        public void Create(OrderVM item)
        {
            Order savedOrder = null;
            string customerName = item.customerName;
            if (customerName.Length != 0)
            {
                using (var context = new DataContext())
                {
                    int customerId = (from c in context.Customer
                                      where c.Name == customerName
                                      select c.Id).FirstOrDefault();

                    var order = new Order() { CustomerId = customerId, Date = item.orderDate };
                    context.Order.Add(order);
                    context.SaveChanges();
                    var orderId = (from o in context.Order
                                   where o.CustomerId == customerId && o.Date == item.orderDate
                                       select o.Id).FirstOrDefault();
                    foreach (var pos in item.PositionList)
                    {
                        var articleId = (from article in context.Article
                            where pos.articleName == article.Name
                            select article.Id).FirstOrDefault();

                        var position = new Position(pos.quantity, 0, 0, articleId, orderId);
                        context.Position.Add(position);
                    }
                    context.SaveChanges();


                    //savedOrder = context.Order.Find(order.Id);
                }
            }
        }

        public bool Delete(OrderVM item)
        {
            throw new NotImplementedException();
        }

        public List<OrderVM> Read()
        {
            throw new NotImplementedException();
        }

        public OrderVM ReadSingle(OrderVM customerVm)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderVM item)
        {
            throw new NotImplementedException();
        }

        public List<string> ReadCustomerNames()
        {
            try
            {
                using (var context = new DataContext())
                {
                    return (from customer in context.Customer
                        select customer.Name).ToList();
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
        }
        public List<string> ReadArticles()
        {
            try
            {
                using (var context = new DataContext())
                {
                    return (from article in context.Article
                        select article.Name).ToList();
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Fehler beim auslesen der Daten von der Datenbank. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
        }
    }
}
