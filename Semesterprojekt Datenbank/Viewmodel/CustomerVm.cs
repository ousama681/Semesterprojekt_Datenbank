using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using System.Collections.Generic;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class CustomerVm : Utilities.ViewModelBase
    {
        public static List<CustomerVm> CustomerList { get; set; } = new List<CustomerVm>();
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

        public bool DeleteCustomer(CustomerVm customerVm)
        {
            return dB.Delete(customerVm);
        }
        public bool IsCustomerNrUsed(int nr)
        {
            bool nrUsed = false;
            foreach (var vm in CustomerList)
            {
                if (nr == vm.Nr)
                {
                    nrUsed = true;
                    return nrUsed;
                }
            }
            return false;
        }
    }
}

