using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Documents;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Semesterprojekt_Datenbank.Utilities
{


    public class DBUtilityInvoice : IDBUtility<InvoiceVm>
    {

        public bool Create(InvoiceVm item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InvoiceVm item)
        {
            throw new NotImplementedException();
        }

        public List<InvoiceVm> Read()
        {
            try
            {
                List<InvoiceVm> list = new List<InvoiceVm>();

                using (var context = new DataContext())
                {

                    var allDataForInvoice = (from t in context.Town
                        join c in context.Customer on t.Id equals (c.TownId)
                        join o in context.Order on c.Id equals (o.CustomerId)
                        join i in context.Invoice on o.Id equals (i.OrderId)

                        select new
                        {
                            i.Id,
                            i.Date,
                            i.NetPrice,
                            c.Nr,
                            c.Name,
                            c.Street,
                            t.ZipCode,
                            t.City,
                            t.Country,
                        }).ToList();

                    foreach (var item in allDataForInvoice)
                    {
                        InvoiceVm invoiceVm = new InvoiceVm(item.Id, item.Date, item.NetPrice, item.Nr, item.Name, item.ZipCode, item.Street, item.City, item.Country);

                        list.Add(invoiceVm);

                    }
                    return list;

                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Artikelgruppe konnte nicht gespeichert werden. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Artikelgruppe konnte nicht gespeichert werden. \r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return null;
            }
           
        }


        public List<string> ReadFilter(List<string> item)
        {
            List<InvoiceVm> list = new List<InvoiceVm>();

            using (var context = new DataContext())
            {
                var queryAlldata = (from t in context.Town
                                    join c in context.Customer on t.Id equals (c.TownId)
                                    join o in context.Order on c.Id equals (o.CustomerId)
                                    join i in context.Invoice on o.Id equals (i.OrderId)

                                    where i.Id == item.Count() 

                                    select i).ToList();
                                   
                                    //select new
                                    //{

                                    //    i.Id,
                                    //    i.Date,
                                    //    i.NetPrice,
                                    //    c.Nr,
                                    //    c.Name,
                                    //    c.Street,
                                    //    t.ZipCode,
                                    //    t.City,
                                    //    t.Country,
                                    //}).ToList();
            };
            return null;
        }

        public List<InvoiceVm> ReadFilteredData(string whereQuery)
        {
            try
            {
                List<InvoiceVm> list = new List<InvoiceVm>();
                using (var context = new DataContext()){
                    SqlConnection conn = new SqlConnection(DataContext.GetConnectionStringByName("connection"));
                    SqlCommand cmd = new SqlCommand("Select Invoice.Id, Invoice.Date, Invoice.NetPrice, Customer.Nr, Customer.Name, Town.ZipCode, Customer.Street, Town.City, Town.Country From Customer join Town on Town.Id = Customer.TownId join [Order] on Customer.Id = [Order].Id join Invoice on [Order].Id = Invoice.OrderId " + $"{ whereQuery }", conn);
                    conn.Open();
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var vm = new InvoiceVm((int)reader[0], (DateTime)reader[1], (decimal)reader[2],
                            (int)reader[3], (string)reader[4], (string)reader[5], (string)reader[6], (string)reader[7], (string)reader[8]);
                        list.Add(vm);
                    }
                    context.SaveChanges();
                    conn.Close();
                return list;
                };
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Error Message: \r\n" + e.Message);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Message: \r\n" + e.Message);
                return null;
            }
           
        }
        public InvoiceVm ReadSingle(InvoiceVm filterList)
        {
            throw new NotImplementedException();
        }

        public void Update(InvoiceVm item)
        {
            throw new NotImplementedException();
        }
    }
}
