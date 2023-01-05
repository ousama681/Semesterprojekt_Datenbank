using Semesterprojekt_Datenbank.Viewmodel;

namespace DBS_View.View
{
    public partial class AddCustomerForm : Form
    {
        CustomerVm customerVm;
        CustomerForm customerForm;
        private bool isCustomerUpdated;

        public AddCustomerForm()
        {
            InitializeComponent();
            customerForm = new CustomerForm();
            customerVm = new CustomerVm();
        }

        public AddCustomerForm(CustomerVm customerVm)
        {
            InitializeComponent();
            customerForm = new CustomerForm();
            this.customerVm = new CustomerVm();
            isCustomerUpdated= true;
            
            TxtCustomerName.Text = customerVm.Name;
            TxtCustomerNr.Text = customerVm.Nr.ToString();
            TxtStreet.Text = customerVm.Street;
            TxtTown.Text = customerVm.City;
            TxtZipCode.Text = customerVm.ZipCode;
            TxtEmail.Text = customerVm.Email;
            TxtWebsite.Text = customerVm.Website;
            TxtPassword.Text = customerVm.Password;
            TxtCustomerNr.Enabled = false;

        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if(customerVm.isCustomerNrUsed(Convert.ToInt32(TxtCustomerNr.Text)))
            {
                customerVm.Name = TxtCustomerName.Text;
                if (TxtCustomerNr.TextLength > 0)
                    customerVm.Nr = Convert.ToInt32(TxtCustomerNr.Text);
                customerVm.Street = TxtStreet.Text;
                customerVm.City = TxtTown.Text;
                customerVm.ZipCode = TxtZipCode.Text;
                customerVm.Email = TxtEmail.Text;
                customerVm.Website = TxtWebsite.Text;
                customerVm.Password = TxtPassword.Text.GetHashCode().ToString();

                if (isCustomerUpdated != true)
                {
                    customerVm.CreateCustomer(customerVm);
                }
                else
                {
                    customerVm.UpdateCustomer(customerVm);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Kundennr bereits vergeben. Bitte andere Kundennummer auswählen.");
            }

        }


    }
}
