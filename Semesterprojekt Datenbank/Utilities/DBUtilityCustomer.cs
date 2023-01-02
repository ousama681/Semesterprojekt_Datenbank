using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
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
                    Customer c = new Customer(customerVm.Id, customerVm.Nr, customerVm.Name, customerVm.Email, customerVm.Website, customerVm.Password, customerVm.Street, id);
                    context.Add(c);
                    mb.Entity<Customer>().HasData(new Customer()
                    {
                        Id = id,
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

        public List<CustomerVm> Read()
        {
            try
            {
                using (var context = new DataContext())
                {
                    List<CustomerVm> vmList = new List<CustomerVm>();
                    var queryCustomer = (from customer in context.Customer
                                         select customer).ToList();
                    foreach (var customer in queryCustomer)
                    {
                        var queryTown = (from town in context.Town
                                         where town.Id == customer.TownId
                                         select town).FirstOrDefault();

                        CustomerVm vm = new CustomerVm(customer.Id, customer.Nr, customer.Name, customer.Street, queryTown.ZipCode, queryTown.City, customer.Email, customer.Website, customer.Password);
                        vmList.Add(vm);
                    }
                    return vmList;
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
        public CustomerVm ReadSingle(CustomerVm findCustomerVM)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var querySingleCustomer = (from customer in context.Customer
                                               where customer.Nr == findCustomerVM.Nr
                                               select customer).SingleOrDefault();

                    var querySingleTown = (from town in context.Town
                                           where town.Id == querySingleCustomer.TownId
                                           select town).FirstOrDefault();

                    CustomerVm vm = new CustomerVm(querySingleCustomer.Id, querySingleCustomer.Nr, querySingleCustomer.Name, querySingleCustomer.Street, querySingleTown.ZipCode, querySingleTown.City, querySingleCustomer.Email, querySingleCustomer.Website, querySingleCustomer.Password);
                    return vm;
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

        public void Update(CustomerVm customerVm)
        {
            try
            {
                using (var context = new DataContext())
                {
                    var queryForCustomer = (from customer in context.Customer
                                            where customer.Nr == customerVm.Nr
                                            select customer).SingleOrDefault();
                    var queryForTown = (from town in context.Town
                                        where town.ZipCode == customerVm.ZipCode
                                        select town).FirstOrDefault();

                    queryForCustomer.Nr = customerVm.Nr;
                    queryForCustomer.Name = customerVm.Name;
                    queryForCustomer.Street = customerVm.Street;
                    queryForCustomer.Email = customerVm.Email;
                    queryForCustomer.Website = customerVm.Website;
                    queryForCustomer.Password = customerVm.Password;
                    queryForCustomer.TownId = queryForTown.Id;

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

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
