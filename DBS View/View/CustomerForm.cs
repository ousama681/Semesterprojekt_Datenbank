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
using System.Windows.Markup;
using Semesterprojekt_Datenbank.Viewmodel;
using System.Windows.Controls;

namespace DBS_View.View
{
    public partial class CustomerForm : Form
    {
        private CustomerVm customerVm;
        public CustomerForm()
        {
            //CustomerVm.CustomerList.Add(new CustomerVm(1,"s","sdf@d","fds.ch", "pw", "street", 12));
            //CustomerVm.CustomerList.Add(new CustomerVm(2, "s", "sdf@d", "fds.ch", "pw", "street", 12));
            //CustomerVm.CustomerList.Add(new CustomerVm(3, "s", "sdf@d", "fds.ch", "pw", "street", 12));
            //CustomerVm.CustomerList.Add(new CustomerVm(4, "s", "sdf@d", "fds.ch", "pw", "street", 12));
            //CustomerVm.CustomerList.Add(new CustomerVm(5, "s", "sdf@d", "fds.ch", "pw", "sdsfds", 12));
            InitializeComponent();
            customerVm = new CustomerVm();
            
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void CmdAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.FormClosed += new FormClosedEventHandler(this.AddCustomerForm_FormClosed);
            addCustomerForm.ShowDialog();
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------------------------------
            //Muss noch aus der DB gelöscht werden!!!!!!!!!!!!!
            //--------------------------------------------------------------------------

            if (DgvCustomer.CurrentRow != null)
            {
                // Create row and column variable for better readability
                DataGridViewColumnCollection column = DgvCustomer.Columns;
                // Getting column number to prevent errors when changing the order of the columns
                string customerName = Convert.ToString(DgvCustomer.CurrentRow.Cells[column["colName"].Index].Value);

                if (MessageBox.Show("Möchten Sie den Kunden" + " \"" + customerName + "\" " +
                                    "wirklich löschen?", "Eintrag löschen?", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Customer cu = CustomerVm.CustomerList.Find(x => x.Name == customerName);

                    // Search Data.CustomerList for customers with the same ContactPerson
                    // This prevents an error when deleting a customer with the same ContactPerson as another customer
                    //List<Customer> customerList = CustomerVm.CustomerList.FindAll(x => x.ContactPerson == cu.ContactPerson);
                    ////List<Customer> customerList = Data.CustomerList.FindAll(x => x.Equals(cu.ContactPerson));
                    //if (customerList.Count <= 1)
                    //{
                    //    CustomerVm.PersonList.Remove(cu.ContactPerson);
                    //}
                    //CustomerVm.CustomerList.Remove(cu);
                    DgvCustomer.Rows.RemoveAt(DgvCustomer.CurrentRow.Index);

                    //CsvHandler.WriteToCsv(CustomerVm.PersonList, CustomerVm.EmployeeList, CustomerVm.ApprenticeList, CustomerVm.CadreList, CustomerVm.CustomerList,
                    //                @"saveDataPerson.csv", @"saveDataEmployee.csv", @"saveDataApprentice.csv", @"saveDataCadre.csv", @"saveDataCustomer.csv");
                }
            }
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        private void AddCustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillDataGrid();
        }

        private void DataResultList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridSender = (DataGridView)sender;

            if (gridSender.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.ColumnIndex >= 0)
            {
                int customerNameColumnIndex = DgvCustomer.Columns["colName"].Index;
                DataGridViewRow row = DgvCustomer.Rows[e.RowIndex];
                DataGridViewCell cell = row.Cells[customerNameColumnIndex];
                string customerName = Convert.ToString(cell.Value);

                CustomerVm cu = CustomerVm.CustomerList.Find(x => x.Name == customerName);

                AddCustomerForm addCustomerForm = new AddCustomerForm(cu);
                addCustomerForm.FormClosed += new FormClosedEventHandler(this.AddCustomerForm_FormClosed);
                addCustomerForm.ShowDialog();
            }
        }

        private void FillDataGrid()
        {
            DgvCustomer.Rows.Clear();

            // Create row and column variable for better readability
            DataGridViewRowCollection row = DgvCustomer.Rows;

            DataGridViewColumnCollection column = DgvCustomer.Columns;

            foreach (CustomerVm customer in CustomerVm.CustomerList)
            {
                // Add new row to DataGridView
                int rowIndex = row.Add();

                // Create cell variable for better readability
                DataGridViewCellCollection cell = row[rowIndex].Cells;

                // Add data to new row
                cell[column["colNr"].Index].Value = customer.Nr;
                cell[column["colName"].Index].Value = customer.Name;
                cell[column["colEmail"].Index].Value = customer.Email;
                cell[column["colStreet"].Index].Value = customer.Street;
                cell[column["colTown"].Index].Value = customer.City;
                cell[column["colZipCode"].Index].Value = customer.ZipCode;
                
                //cell[column["dcolBusinessPhoneNumber"].Index].Value = cu.BusinessPhoneNumber;
                //cell[column["dcolFaxNumber"].Index].Value = cu.FaxNumber;
                //cell[column["dcolContactPerson"].Index].Value = cu.ContactPersonString;
                //cell[column["dcolCustomerType"].Index].Value = cu.CustomerType;
                //cell[column["dcolStatus"].Index].Value = cu.ContactPerson.Status ? "✔️ Aktiv" : "🚫 Passiv";
            }
            //DgvCustomer.Sort(column["colName"], ListSortDirection.Ascending);
            DgvCustomer.ClearSelection();
        }

        private void SearchCustomer()
        {
            // Create row and column variable for better readability
            DataGridViewColumnCollection column = DgvCustomer.Columns;

            int count = 0;
            // Check every row for cells that contain the search string
            if (TxtSearch.Text.Length >= 3)
            {
                foreach (DataGridViewRow row in DgvCustomer.Rows)
                {
                    row.Visible = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            // search for cells containing string but not cells that are in a button column
                            if (cell.Value.ToString().Contains(TxtSearch.Text, StringComparison.OrdinalIgnoreCase) &&
                                !(cell.OwningColumn is DataGridViewButtonColumn))
                            {
                                row.Visible = true;
                                cell.Selected = true;
                                count++;
                                break;
                            };
                        }
                        
                    }
                }
                if (count == DgvCustomer.RowCount)
                {
                    MessageBox.Show("Das Suchergebniss entspricht allen Feldern." + "\r\n" + "Bitte die Suche weiter Eingrenzen",
                                    "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Die Suche ergab " + count + " Treffer", "Hinweis", MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk);
                }
                DgvCustomer.Sort(column["colName"], ListSortDirection.Ascending);
                DgvCustomer.ClearSelection();
            }
            else
            {
                MessageBox.Show("Bitte mindestens drei Zeichen für die Suche eingeben");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearch.Text.Length < 1)
            {
                foreach (DataGridViewRow row in DgvCustomer.Rows)
                {
                    row.Visible = true;
                }
                DgvCustomer.ClearSelection();
            }
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchCustomer();

                // Suppresses the Windows sound if "enter" is pressed in a single line textbox
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}

