using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using System.Collections.Generic;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class CustomerVm : Utilities.ViewModelBase
    {
        public static List<CustomerVm> CustomerList { get; set; } = new List<CustomerVm>();

        private readonly Town town = new Town();
        private readonly Customer customer = new Customer();
        private DBUtilityCustomer dB = new DBUtilityCustomer();

        

        public int Nr
        {
            get { return customer.Nr; }
            set { customer.Nr = value; /*OnPropertyChanged();*/ }
        }

        public string Name
        {
            get { return customer.Name; }
            set { customer.Name = value; /*OnPropertyChanged();*/ }
        }

        public string Email
        {
            get { return customer.Email; }
            set { customer.Email = value; /*OnPropertyChanged();*/ }
        }

        public string Website
        {
            get { return customer.Website; }
            set { customer.Website = value; /*OnPropertyChanged();*/ }
        }

        public string Password
        {
            get { return customer.Password; }
            set { customer.Password = value; /*OnPropertyChanged();*/ }
        }

        public string Street
        {
            get { return customer.Street; }
            set { customer.Street = value; /*OnPropertyChanged();*/ }
        }
        public string ZipCode 
        {
            get { return town.ZipCode; }
            set { town.ZipCode = value; } 
        }
        public string City
        {
            get { return town.City; }
            set { town.City = value; }
        }


        //public int TownId
        //{
        //    get { return customer.TownId; }
        //    set { customer.TownId = value; /*OnPropertyChanged();*/ }
        //}

        public CustomerVm()
        {
            
            //customer = new Customer(1, 1, "fluffy", "macpants@hotchicks.ch", "How To MVVM, wtf!!?!.ch", "ligma", "WPFAvenue", 6666);
        }


        public void CreateCustomer()
        {
            dB.Create(customer);
        }
    }
}
//public virtual Town Town { get; set; }
//public virtual ICollection<Invoice> Invoices { get; set; }
//public virtual ICollection<Order> Orders { get; set; }
