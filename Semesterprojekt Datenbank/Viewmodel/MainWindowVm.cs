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
        private DBUtilityMainWindow dBMainWindow = new DBUtilityMainWindow();
        SearchView searchView;

        public void Search(string searchText)
        {
            var dataTable = dBMainWindow.Read(searchText);
            searchView = new SearchView();
            searchView.SetDataGridContent(dataTable);
        }
    }
}
