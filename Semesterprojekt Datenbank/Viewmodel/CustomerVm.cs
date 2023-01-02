using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using System.Collections.Generic;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class CustomerVm : Utilities.ViewModelBase
    {
        public static List<CustomerVm> CustomerList { get; set; } = new List<CustomerVm>();

        private readonly Town town = new Town();
        //private readonly CustomerVm customer;
        private DBUtilityCustomer dB = new DBUtilityCustomer();

        public int Id { get; set; }
        public int Nr { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Password { get; set; }

        public CustomerVm(int id,int nr, string name, string street, string zipCode, string city, string email, string website, string password)
        {
            Id= id;
            Nr = nr;
            Name = name;
            Street = street;
            ZipCode = zipCode;
            City = city;
            Email = email;
            Website = website;
            Password = password;
        }

        //public int Nr
        //{
        //    get { return Nr; }
        //    set { customer.Nr = value; /*OnPropertyChanged();*/}
        //}

        //public string Name
        //{
        //    get { return customer.Name; }
        //    set { customer.Name = value; /*OnPropertyChanged();*/ }
        //}

        //public string Email
        //{
        //    get { return customer.Email; }
        //    set { customer.Email = value; /*OnPropertyChanged();*/ }
        //}

        //public string Website
        //{
        //    get { return customer.Website; }
        //    set { customer.Website = value; /*OnPropertyChanged();*/ }
        //}

        //public string Password
        //{
        //    get { return customer.Password; }
        //    set { customer.Password = value; /*OnPropertyChanged();*/ }
        //}

        //public string Street
        //{
        //    get { return customer.Street; }
        //    set { customer.Street = value; /*OnPropertyChanged();*/ }
        //}
        //public string ZipCode 
        //{
        //    get { return town.ZipCode; }
        //    set { town.ZipCode = value; } 
        //}
        //public string City
        //{
        //    get { return town.City; }
        //    set { town.City = value; }
        //}


        //public int TownId
        //{
        //    get { return customer.TownId; }
        //    set { customer.TownId = value; /*OnPropertyChanged();*/ }
        //}

        public CustomerVm()
        {

        }


        public void CreateCustomer(CustomerVm customer)
        {
            dB.Create(customer);

        }

        public void UpdateCustomer(CustomerVm updatecustomerVm)
        {
            var outputDbCustomer = dB.ReadSingle(updatecustomerVm);

            if (!outputDbCustomer.Equals(updatecustomerVm))
            {
                dB.Update(updatecustomerVm);
            }

        }
    }
}

