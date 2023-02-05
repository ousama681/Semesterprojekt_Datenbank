﻿using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Model;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;

namespace Semesterprojekt_Datenbank.Utilities
{


    public class DBUtilityInvoice : IDBUtility<InvoiceVm>
    {

        public bool Create(InvoiceVm item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(InvoiceVm item)
        {
            throw new NotImplementedException();
        }

        public List<InvoiceVm> Read()
        {
            List<InvoiceVm> list = new List<InvoiceVm>();

            using (var context = new DataContext())
            {

                var allDataForInvoice = (from t in context.Town
                                         join c in context.Customer on t.Id equals (c.TownId)
                                         join o in context.Order on c.Id equals (o.CustomerId)
                                         join i in context.Invoice on o.Id equals (i.OrderId)

                                         select new
                                         {
                                             i.Id,
                                             i.Date,
                                             i.NetPrice,
                                             c.Nr,
                                             c.Name,
                                             c.Street,
                                             t.ZipCode,
                                             t.City,
                                             t.Country,
                                         }).ToList();

                foreach (var item in allDataForInvoice)
                {
                    InvoiceVm invoiceVm = new InvoiceVm(item.Id, item.Date, item.NetPrice, item.Nr, item.Name, item.ZipCode, item.City, item.Country);

                    list.Add(invoiceVm);

                }
                return list;

            }
        }


        public List<string> ReadFilter(List<string> item)
        {
            List<InvoiceVm> list = new List<InvoiceVm>();




            using (var context = new DataContext())
            {
                var queryAlldata = (from t in context.Town
                                    join c in context.Customer on t.Id equals (c.TownId)
                                    join o in context.Order on c.Id equals (o.CustomerId)
                                    join i in context.Invoice on o.Id equals (i.OrderId)

                                    where i.Id == item.Count() 

                                    select i).ToList();
                                   
                                    //select new
                                    //{

                                    //    i.Id,
                                    //    i.Date,
                                    //    i.NetPrice,
                                    //    c.Nr,
                                    //    c.Name,
                                    //    c.Street,
                                    //    t.ZipCode,
                                    //    t.City,
                                    //    t.Country,
                                    //}).ToList();

                
            };
            return null;
       



        }

        public InvoiceVm ReadSingle(InvoiceVm filterList)
        {
            throw new NotImplementedException();
        }

        public void Update(InvoiceVm item)
        {
            throw new NotImplementedException();
        }
    }
}