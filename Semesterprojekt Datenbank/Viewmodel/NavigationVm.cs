﻿using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using Semesterprojekt_Datenbank.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class NavigationVm : Utilities.ViewModelBase
    {
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }


        public ICommand CustomerCommand { get; set; }
        public ICommand ArticleCommand { get; set; }
        //public ICommand OrdersCommand { get; set; }
        //public ICommand TransactionCommand { get; set; }
        //public ICommand ShipmentCommand { get; set; }
        //public ICommand SettingsCommand { get; set; }

  
        private void Customer(object obj) => CurrentView = new CustomerVm();
        private void Article(object obj) => CurrentView = new MainWindowVm();
        //private void Order(object obj) => CurrentView = new OrderVM();
        //private void Transaction(object obj) => CurrentView = new TransactionVM();
        //private void Shipment(object obj) => CurrentView = new ShipmentVM();
        //private void Setting(object obj) => CurrentView = new SettingVM();

        public NavigationVm()
        {
       
            CustomerCommand = new RelayCommand(Customer);
            ArticleCommand = new RelayCommand(Article);
            //OrdersCommand = new RelayCommand(Order);
            //TransactionCommand = new RelayCommand(Transaction);
            //ShipmentCommand = new RelayCommand(Shipment);
            //SettingsCommand = new RelayCommand(Setting);


            // Startup Page
            //CurrentView = new HomeVM();
        }

    }
}
