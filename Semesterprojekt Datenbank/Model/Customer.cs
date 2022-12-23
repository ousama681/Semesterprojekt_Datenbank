using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public int Nr { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Password { get; set; }
        public string Street { get; set; }
        public int TownId { get; set; }
        public virtual Town Town { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public Customer(int id, int nr, string name, string email, string website, string password, string street, int townId)
        {
            Id = id;
            Nr = nr;
            Name = name;
            Email = email;
            Website = website;
            Password = password;
            Street = street;
            TownId = townId;
        }
        public Customer() { }
    }
}
