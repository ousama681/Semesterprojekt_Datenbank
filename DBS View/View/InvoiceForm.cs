using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_View.View
{
    public partial class InvoiceForm : Form
    {
        InvoiceVm vm;


        public InvoiceForm()
        {
            InitializeComponent();
            vm= new InvoiceVm();

            DgvSearch.DataSource= vm.GetInvoices();




        }







    }
}
