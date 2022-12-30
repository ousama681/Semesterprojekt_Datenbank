using Semesterprojekt_Datenbank.View;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
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


namespace Semesterprojekt_Datenbank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowVm mainWindowVm;

        public MainWindow()
        {
            InitializeComponent();
            mainWindowVm = new MainWindowVm();
            

        }

        private void CmdCustomer_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CmdArticle_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void CmdArticleGroup_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ArticleGroup Works!");
        }

        private void CmdOrder_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Order Works!");
        }

        private void CmdSearch_Click(object sender, RoutedEventArgs e)
        {
           mainWindowVm.Search(TxtSearch.Text);
        }
    }
}
