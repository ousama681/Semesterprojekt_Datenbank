using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityCustomer : IDBUtility<CustomerVm>
    {
        ModelBuilder mb = new ModelBuilder();
        public bool Create(CustomerVm item)
        {
            try
            {
                using (var context = new DataContext())
                {
                    Customer c;
                    var id = GetTownId(context, item);
                    if (item is Customer)
                    {
                        c = (Customer)(object)item;
                        context.Add(c);
                        mb.Entity<Customer>().HasData(new Customer()
                        {
                            /*Id = c.Id, */
                            Nr = c.Nr,
                            Name = c.Name,
                            Email = c.Email,
                            Website = c.Website,
                            Password = c.Password,
                            Street = c.Street,
                            TownId = c.TownId
                        });
                        context.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                Console.WriteLine(e);
                MessageBox.Show("Kunde konnte nicht gespeichert werden. Keine Verbindung zur Datenbank!\r\n \r\n" + "Error Message: \r\n" + e.Message);
                return false;
            }
            return false;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read(CustomerVm item)
        {

        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public int GetTownId(DataContext context, CustomerVm customer)
        {
            var id = (from town in context.Town
                     where town.ZipCode.Contains(customer.ZipCode)
                     select town.Id).Single();
            return Convert.ToInt32(id);
        }
    }
}
