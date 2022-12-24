using Microsoft.EntityFrameworkCore;
using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityCustomer /*: IDBUtility<T>*/
    {
        ModelBuilder mb = new ModelBuilder();
        public void Create(Customer item)
        {
            Customer c;
            using (var connection = new DataContext())
            { 
                if (item is Customer)
                {
                    c = (Customer)(object)item;
                    connection.Add(c);
                    mb.Entity<Customer>().HasData(new Customer() 
                    {  
                        Id = c.Id, Nr = c.Nr, Name = c.Name, 
                        Email = c.Email, Website = c.Website, 
                        Password = c.Password, Street = c.Street, 
                        TownId = c.TownId 
                    });
                    connection.SaveChanges();
                }
            }       
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Migrate()
        {
           
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
