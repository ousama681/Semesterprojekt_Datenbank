using Caliburn.Micro;
using Semesterprojekt_Datenbank.Utilities;
using Semesterprojekt_Datenbank.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class MainWindowVm : Utilities.ViewModelBase
    {
        private DBUtilityMainWindow dBmMainWindow = new DBUtilityMainWindow();
        SearchView searchView;

        public void Search(string searchtext)
        {
            var dataTable = dBmMainWindow.Read(searchtext);
            searchView = new SearchView();
            searchView.SetDataGridContent(dataTable);
        }
    }
}
