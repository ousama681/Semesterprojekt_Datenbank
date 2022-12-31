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
            customer = new CustomerVm();
        }
        
        public AddCustomerForm(CustomerVm cu)
        {
            InitializeComponent();
            
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            customer.CreateCustomer();
        }
    }
}
