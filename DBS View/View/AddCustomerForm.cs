using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;

namespace DBS_View.View
{
    public partial class AddCustomerForm : Form
    {
        CustomerVm customer;
        public AddCustomerForm()
        {
            InitializeComponent();
            
        }
        
        public AddCustomerForm(CustomerVm c)
        {
            InitializeComponent();
            TxtCustomerName.Text = c.Name;
            TxtCustomerNr.Text = c.Nr.ToString();
            TxtStreet.Text = c.Street;
            TxtTown.Text = c.City;
            TxtZipCode.Text = c.ZipCode;
            TxtEmail.Text = c.Email;
            TxtWebsite.Text = c.Website;
            TxtPassword.Text = c.Password;

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            customer = new CustomerVm();

            customer.Name = TxtCustomerName.Text;
            if (TxtCustomerNr.TextLength > 0)
                customer.Nr = Convert.ToInt32(TxtCustomerNr.Text);
            customer.Street = TxtStreet.Text;
            customer.City = TxtTown.Text;
            customer.ZipCode = TxtZipCode.Text;
            customer.Email = TxtEmail.Text;
            customer.Website = TxtWebsite.Text;
            customer.Password = TxtPassword.Text.GetHashCode().ToString();

            customer.CreateCustomer(customer);
            this.Close();
        }


    }
}
