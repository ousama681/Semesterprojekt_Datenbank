using Semesterprojekt_Datenbank.Interfaces;
using Semesterprojekt_Datenbank.Viewmodel;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public InvoiceVm ReadSingle(InvoiceVm item)
        {
            throw new NotImplementedException();
        }

        public void Update(InvoiceVm item)
        {
            throw new NotImplementedException();
        }
    }
}
