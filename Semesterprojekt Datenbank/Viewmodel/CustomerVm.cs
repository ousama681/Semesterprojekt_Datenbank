using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using System.Collections.Generic;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class CustomerVm : Utilities.ViewModelBase
    {
        public static List<CustomerVm> CustomerList { get; set; } = new List<CustomerVm>();

        private readonly Town town = new Town();
        //private readonly CustomerVm customerVm;
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
        //    set { customerVm.Nr = value; /*OnPropertyChanged();*/}
        //}

        //public string Name
        //{
        //    get { return customerVm.Name; }
        //    set { customerVm.Name = value; /*OnPropertyChanged();*/ }
        //}

        //public string Email
        //{
        //    get { return customerVm.Email; }
        //    set { customerVm.Email = value; /*OnPropertyChanged();*/ }
        //}

        //public string Website
        //{
        //    get { return customerVm.Website; }
        //    set { customerVm.Website = value; /*OnPropertyChanged();*/ }
        //}

        //public string Password
        //{
        //    get { return customerVm.Password; }
        //    set { customerVm.Password = value; /*OnPropertyChanged();*/ }
        //}

        //public string Street
        //{
        //    get { return customerVm.Street; }
        //    set { customerVm.Street = value; /*OnPropertyChanged();*/ }
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
        //    get { return customerVm.TownId; }
        //    set { customerVm.TownId = value; /*OnPropertyChanged();*/ }
        //}

        public CustomerVm()
        {

        }


        public void CreateCustomer(CustomerVm customerVm)
        {
            dB.Create(customerVm);
        }

        public void UpdateCustomer(CustomerVm CustomerVm)
        {
            var outputDbCustomer = dB.ReadSingle(CustomerVm);

            if (!outputDbCustomer.Equals(CustomerVm))
            {
                dB.Update(CustomerVm);
            }
        }

        public void DeleteCustomer(CustomerVm customerVm)
        {
            dB.Delete(customerVm);
        }
    }
}

