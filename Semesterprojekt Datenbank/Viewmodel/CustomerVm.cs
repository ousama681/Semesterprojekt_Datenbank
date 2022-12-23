using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class CustomerVm : Utilities.ViewModelBase
    {

        private readonly Customer customer = new Customer();
        private DBUtilityCustomer dB = new DBUtilityCustomer();
        public int ID
        {
            get { return customer.Id; }
            set { customer.Id = value; /*OnPropertyChanged();*/ }
        }

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

        public int TownId
        {
            get { return customer.TownId; }
            set { customer.TownId = value; /*OnPropertyChanged();*/ }
        }

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
