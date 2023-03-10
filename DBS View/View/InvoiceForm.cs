using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;

namespace DBS_View.View
{
    public partial class InvoiceForm : Form
    {
        InvoiceVm vm;

        public InvoiceForm()
        {
            InitializeComponent();
            vm = new InvoiceVm();
            AdvDgvInvoice.DataSource = vm.GetInvoices();
            ChkBox.DisplayMember = "Text";
            ChkBox.ValueMember = "Value";
            ChkBox.Items.Insert(0, new {Text = "Rechnungs Nr", Value = "Invoice.Id" });
            ChkBox.Items.Insert(1, new {Text = "Datum", Value = "Invoice.Date" });
            ChkBox.Items.Insert(2, new { Text = "Rechnung Netto", Value = "Invoice.NetPrice" });
            ChkBox.Items.Insert(3, new { Text = "Rechnung Brutto", Value = "Invoice.BruttoPrice" }); //------- Fehlt in DB
            ChkBox.Items.Insert(4, new { Text = "Kunden Nr", Value = "Customer.Id" });
            ChkBox.Items.Insert(5, new { Text = "Name", Value = "Customer.Name" });
            ChkBox.Items.Insert(6, new { Text = "PLZ", Value = "Order.ZipCode" });
            ChkBox.Items.Insert(7, new { Text = "Strasse", Value = "Customer.Street" });
            ChkBox.Items.Insert(8, new { Text = "Ort", Value = "Order.City" });
            ChkBox.Items.Insert(9, new { Text = "Land", Value = "Order.Country" });
        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            var texts = new List<string>();
            if (ChkBox.CheckedItems.Count > 0)
            {
                foreach (object checkedItem in ChkBox.CheckedItems)
                {
                    switch (ChkBox.Items.IndexOf(checkedItem))
                    {
                        case 0:
                            texts.Add("Invoice.Date");
                            break;
                        case 1:
                            texts.Add("Customer.Nr");
                            break;
                        case 2:
                            texts.Add("Town.Country");
                            break;
                        case 3:
                            texts.Add("Customer.Name");
                            break;
                        case 4:
                            texts.Add("Town.City");
                            break;
                        case 5:
                            texts.Add("Town.ZipCode");
                            break;
                        case 6:
                            //texts.Add("Invoice.BruttoPrice"); // nicht fertig implementiert aus zeitgründen
                            break;
                        case 7:
                            texts.Add("Invoice.NetPrice");
                            break;
                        case 8:
                            texts.Add("Invoice.Id");
                            break;
                        case 9:
                            texts.Add("Customer.Street");
                            break;
                    }
                }
            }
            else
            {
                texts.Add("Invoice.Id");
                texts.Add("Invoice.Date");
                texts.Add("Invoice.NetPrice");
                //texts.Add("Invoice.BruttoPrice"); // nicht fertig implementiert aus zeitgründen
                texts.Add("Customer.Nr");
                texts.Add("Customer.Name");
                texts.Add("Town.ZipCode");
                texts.Add("Customer.Street");
                texts.Add("Town.City");
                texts.Add("Town.Country");
            }

            if (TxtSearch.Text.Length > 0)
            {
                this.AdvDgvInvoice.DataSource = null;
                this.AdvDgvInvoice.Rows.Clear();
                string searchText = TxtSearch.Text;
                var whereQuery = GetWhereString(texts, searchText);
                AdvDgvInvoice.DataSource = vm.GetFilteredData(whereQuery);
            }
        }


        private string GetWhereString(List<string> list, string searchText)
        {
            int count = 1;
            string whereQuery = "Where ";
            foreach (var text in list)
            {
                if (list.Count == count)
                {
                    whereQuery += $"{text} like \'%{searchText}%\'";
                    break;
                }
                whereQuery += $"{text} like \'%{searchText}%\' or ";
                count++;
            }
            return whereQuery;
        }


    }
}
