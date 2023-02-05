using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SemesterprojektDatenbank;

namespace Semesterprojekt_Datenbank.Viewmodel
{
    public class InvoiceVm
    {
        DBUtilityInvoice db = new DBUtilityInvoice();

        public MWST mwst = new MWST();

        public InvoiceVm(int id, DateTime date, decimal netPrice, int customerNr, string customerName, string zipCode, string city, string country)
        {
            Id = id;
            Date = date;
            NetPrice = netPrice;
            BurritoPrice = NetPrice + (NetPrice / 100 * Convert.ToDecimal(mwst.TaxValue));
            //OrderId = orderId;
            CustomerNr = customerNr;
            CustomerName = customerName;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }

        [System.ComponentModel.DisplayName("Rechnungs Nr.")]
        public int Id { get; set; }

        [System.ComponentModel.DisplayName("Rechnung Datum")]
        public DateTime Date { get; set; }

        [System.ComponentModel.DisplayName("Rechnung netto")]
        public decimal NetPrice { get; set; }

        [System.ComponentModel.DisplayName("Rechnung brutto")]
        public decimal BurritoPrice { get; set; }

        [System.ComponentModel.DisplayName("Kunden Nr.")]
        public int CustomerNr { get; set; }

        [System.ComponentModel.DisplayName("Name")]
        public string CustomerName { get; set; }

        [System.ComponentModel.DisplayName("PLZ")]
        public string ZipCode { get; set; }

        [System.ComponentModel.DisplayName("Ort")]
        public string City { get; set; }

        [System.ComponentModel.DisplayName("Land")]
        public string Country { get; set; }


        public InvoiceVm() { }

        public List<InvoiceVm> GetInvoices()
        {
            return db.Read();
        }

        public List<string> GetFilteredOptions(List<string> items)
        {
            return db.ReadFilter(items);

        }




    }






}
