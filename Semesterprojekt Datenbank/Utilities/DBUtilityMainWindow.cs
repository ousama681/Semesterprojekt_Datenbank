using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Semesterprojekt_Datenbank.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Controls;

namespace Semesterprojekt_Datenbank.Utilities
{
    public class DBUtilityMainWindow /*: IDBUtility<T>*/
    {
        //Test list for DataGrid Tests
        public static List<Customer> GetSampleCustomerList()
        {
            return new List<Customer>(new Customer[4] {
            new Customer(12, "Zero","2332",
                "12 North Third Street", "Apartment 45",
               " b 23",12),
            new Customer(12, "One","2332",
                "34 West Fifth Street", "Apartment 67",
               " b 23",12),
            new Customer(12, "Two","2332",
                "56 East Seventh Street", "Apartment 89",
               " b 23",12),
            new Customer(12, "Three","2332",
                "78 South Ninth Street", "Apartment 10",
               " b 23",12)
        });
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public DataTable Read(string searchText)
        {
            // Funktioniert noch nicht mit Datatables oder DataSets.
            // evtl. eine liste machen... Testliste funktioniert.
            // Columns müssen nicht unbedingt definiert werden, wenn datagrid über itemsource definiert wird.

            try
            {
                //using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))

                using (SqlConnection connection = new SqlConnection(DataContext.Leandro_Connection))
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    using (DataTable dataTable = new DataTable("Customer"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from Customer WHERE Name=@Name or Email=@Email or Website=@Website or Street=@Street ", connection))
                        {
                            if (searchText.All(char.IsDigit))
                                cmd.Parameters.AddWithValue("nr", Convert.ToInt32(searchText));
                            cmd.Parameters.AddWithValue("name", searchText);  // schaue bei Ihr, hier ist der string ansderst, Format string
                            cmd.Parameters.AddWithValue("Email", searchText);
                            cmd.Parameters.AddWithValue("website", searchText);
                            cmd.Parameters.AddWithValue("street", searchText);

                    //        //Column Definition

                    //        dataTable.Columns.AddRange(new DataColumn[]
                    //        {
                    //new DataColumn("Nr"),
                    //new DataColumn("Name"),
                    //new DataColumn("Email"),
                    //new DataColumn("Website"),
                    //new DataColumn("Strasse")
                    //        });

                    //        // Dummy Row for Testing

                    //        DataRow dummyRow = dataTable.NewRow();
                    //        dummyRow["Nr"] = 12;
                    //        dummyRow["Name"] = "Dummy";
                    //        dummyRow["Email"] = "Test@Mail.ch";
                    //        dummyRow["Website"] = "Testsite.ch";
                    //        dummyRow["Strasse"] = "Bahnhofstr. 6";

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            adapter.Fill(dataTable);

                            return dataTable;
                        }
                    }
                }
                }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}



