using Semesterprojekt_Datenbank.Viewmodel;

namespace DBS_View.View
{
    public partial class AddCustomerForm : Form
    {
        CustomerVm customer;
        CustomerForm customerForm;
        public bool isCustomerUpdated = false;

        public AddCustomerForm()
        {
            InitializeComponent();
            customerForm = new CustomerForm();
            customer = new CustomerVm();


        }

        public AddCustomerForm(CustomerVm c)
        {
            InitializeComponent();
            customerForm = new CustomerForm();
            customer = new CustomerVm();
            isCustomerUpdated= true;
            
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

            customer.Name = TxtCustomerName.Text;

            if (TxtCustomerNr.TextLength > 0)
                customer.Nr = Convert.ToInt32(TxtCustomerNr.Text);
            customer.Street = TxtStreet.Text;
            customer.City = TxtTown.Text;
            customer.ZipCode = TxtZipCode.Text;
            customer.Email = TxtEmail.Text;
            customer.Website = TxtWebsite.Text;
            customer.Password = TxtPassword.Text.GetHashCode().ToString();

            if (isCustomerUpdated != true)
            {
                customer.CreateCustomer(customer);
            }

            else
            {
                customer.UpdateCustomer(customer);
            }

            this.Close();



        }


    }
}
