using Semesterprojekt_Datenbank.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Semesterprojekt_Datenbank.View
{
    /// <summary>
    /// Interaction logic for SearchView.xaml
    /// </summary>
    public partial class SearchView : UserControl
    {
        public SearchView()
        {
            InitializeComponent();
            TXTTest.Text = "Hello";
            
        }

        private void TXTTest_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DGSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public void SetDataGridContent(DataTable dataTable)
        {
            dataGridXaml.ItemsSource = dataTable.DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            dataGridXaml.ItemsSource = DBUtilityMainWindow.GetSampleCustomerList();
        }
    }
}
