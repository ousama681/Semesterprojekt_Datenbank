using Semesterprojekt_Datenbank.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class MainWindowVm : Utilities.ViewModelBase
    {
        private DBUtilityMainWindow dBmMainWindow = new DBUtilityMainWindow();
        //public string SearchText { get; set ; }

        public DataTable Search(string searchtext)
        {
           var dataTable = dBmMainWindow.Read(searchtext);

            return dataTable;
           
        }
    }
}
