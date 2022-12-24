using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Semesterprojekt_Datenbank.Viewmodel;

namespace Semesterprojekt_Datenbank.View
{
    /// <summary>
    /// Interaction logic for CustomerView.xaml
    /// </summary>
    public partial class CustomerView : UserControl
    {
        CustomerVm vm;
        public CustomerView()
        {           
            InitializeComponent();
            vm = new CustomerVm();
            customerId.Text = 12.ToString();
            Nr.Text = 24.ToString();
            customerName.Text = "Thomas";
            Email.Text = "kehl@bro.ch";
            Website.Text = "chillerroom.ch";
            Password.Text= "Password";
            Street.Text = "ggdfd";
            ZipCode.Text = 1.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //vm.ID = Convert.ToInt16(customerId.Text);
            vm.Nr = Convert.ToInt16(Nr.Text);
            vm.Name = customerName.Text;
            vm.Email = Email.Text;
            vm.Website = Website.Text;
            vm.Password = Password.Text.GetHashCode().ToString();
            vm.Street= Street.Text;
            vm.TownId = Convert.ToInt16(ZipCode.Text);
            vm.CreateCustomer();
        }
    }
}
