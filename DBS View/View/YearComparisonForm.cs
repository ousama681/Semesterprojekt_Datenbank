using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Semesterprojekt_Datenbank;

namespace DBS_View.View
{
    public partial class YearComparisonForm : Form
    {
        public YearComparisonForm()
        {
            InitializeComponent();

            var select = "SELECT * FROM view_Jahresvergleich";
            var c = new SqlConnection(DataContext.GetConnectionStringByName("connection")); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            DgVJahresvergleich.ReadOnly = true;
            DgVJahresvergleich.DataSource = ds.Tables[0];
        }
    }
}
