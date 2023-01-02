using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Linq;
using System.Windows;


namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityCustomer : IDBUtility<CustomerVm>
    {
        ModelBuilder mb = new ModelBuilder();
        public void Create(CustomerVm customerVm)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var id = GetTownId(context, customerVm);
                    Customer c = new Customer(customerVm.Nr, customerVm.Name, customerVm.Email, customerVm.Website, customerVm.Password, customerVm.Street, id);
                    context.Add(c);
                    mb.Entity<Customer>().HasData(new Customer()
                    {
                        Nr = c.Nr,
                        Name = c.Name,
                        Email = c.Email,
                        Website = c.Website,
                        Password = c.Password,
                        Street = c.Street,
                        TownId = id
                    });
                    context.SaveChanges();
                    CustomerVm.CustomerList.Add(customerVm);
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Kunde konnte nicht gespeichert werden. Keine Verbindung zur Datenbank!\r\n \r\n" +
                                "Error Message: \r\n" + e.Message);
                return;
            }
            catch (Exception e)
            {
               MessageBox.Show("Kunde konnte nicht gespeichert werden. \r\n \r\n" +
                    "Error Message: \r\n" + e.Message);
                return;
            }
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
                      select town.Id).FirstOrDefault();
            return Convert.ToInt32(id);
        }
    }
}
