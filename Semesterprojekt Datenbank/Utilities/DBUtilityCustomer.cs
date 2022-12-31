using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityCustomer : IDBUtility<CustomerVm>
    {
        ModelBuilder mb = new ModelBuilder();
        public void Create(CustomerVm item)
        {
            Customer c;
            using (var context = new DataContext())
            {
                var id = GetTownId(context, item);
                if (item is Customer)
                {
                    c = (Customer)(object)item;
                    context.Add(c);
                    mb.Entity<Customer>().HasData(new Customer() 
                    {  
                        /*Id = c.Id, */Nr = c.Nr, Name = c.Name, 
                        Email = c.Email, Website = c.Website, 
                        Password = c.Password, Street = c.Street,
                        TownId = c.TownId
                    });
                    context.SaveChanges();
                }
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
            var id = from town in context.Town
                     where town.ZipCode.Contains(customer.ZipCode)
                     select town.Id;
            return Convert.ToInt32(id);
        }
    }
}
