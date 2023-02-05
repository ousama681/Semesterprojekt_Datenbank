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

            // DgvSearch.DataSource= vm.GetInvoices();

            AdvDgvInvoice.DataSource = vm.GetInvoices();

            ChkBox.DisplayMember = "Text";
            ChkBox.ValueMember = "Value";
            ChkBox.Items.Insert(0, new { Value = $"{vm.Id}" });
            ChkBox.Items.Insert(0, new { Value = $"{vm.Date}" });
            ChkBox.Items.Insert(0, "Rechnungs Nr");
            ChkBox.Items.Insert(1, "Rechnungs Datum");
            ChkBox.Items.Insert(2, "Rechnung Netto");
            ChkBox.Items.Insert(3, "Rechnung Brutto");
            ChkBox.Items.Insert(4, "Kunden Nr");
            ChkBox.Items.Insert(5, "Name");
            ChkBox.Items.Insert(6, "Plz");
            ChkBox.Items.Insert(7, "Ort");
            ChkBox.Items.Insert(8, "Land");




        }

        private void CmdSearch_Click(object sender, EventArgs e)
        {
            this.AdvDgvInvoice.DataSource = null;
            this.AdvDgvInvoice.Rows.Clear();

            var texts = this.ChkBox.CheckedItems.Cast<object>()
                .Select(x => this.ChkBox.GetItemText(x));

            MessageBox.Show(string.Join(",", texts));

            var yourList = texts.ToList();

            AdvDgvInvoice.DataSource = vm.GetFilteredOptions(yourList);




        }





    }
}
