using Semesterprojekt_Datenbank.Viewmodel;

namespace DBS_View.View
{
    public partial class AddCustomerForm : Form
    {
        CustomerVm customerVm;
        private bool isCustomerUpdated;

        public AddCustomerForm()
        {
            InitializeComponent();
            customerVm = new CustomerVm();
        }

        public AddCustomerForm(CustomerVm customerVm)
        {
            InitializeComponent();
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
            try
            {
                customerVm.Name = TxtCustomerName.Text;
                customerVm.Street = TxtStreet.Text;
                customerVm.City = TxtTown.Text;
                customerVm.ZipCode = TxtZipCode.Text;
                customerVm.Email = TxtEmail.Text;
                customerVm.Website = TxtWebsite.Text;
                customerVm.Password = TxtPassword.Text.GetHashCode().ToString();

                if (isCustomerUpdated != true)
                {
                    if (!customerVm.IsCustomerNrUsed(Convert.ToInt32(TxtCustomerNr.Text)) &&
                        TxtCustomerNr.TextLength > 0)
                    {
                        customerVm.Nr = Convert.ToInt32(TxtCustomerNr.Text);
                        customerVm.CreateCustomer(customerVm);
                    }
                    else
                    {
                        MessageBox.Show(this, "Kundennr bereits vergeben. Bitte andere Kundennummer auswählen.");
                    }
                }
                else
                {
                    customerVm.Nr = Convert.ToInt32(TxtCustomerNr.Text);
                    customerVm.UpdateCustomer(customerVm);
                }
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Bitte korrekte Werte in alle Felder eingeben");
            }
            
            
        }
    }
}
