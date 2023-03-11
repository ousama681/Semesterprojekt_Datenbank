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
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    using (DataTable dataTable = new DataTable("Customer"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * from Customer WHERE Name=@Name or Email=@Email or Website=@Website or Street=@Street ", connection))
                        {
                            if (searchText.All(char.IsDigit))
                                cmd.Parameters.AddWithValue("nr", Convert.ToInt32(searchText));
                            cmd.Parameters.AddWithValue("name", searchText);
                            cmd.Parameters.AddWithValue("Email", searchText);
                            cmd.Parameters.AddWithValue("website", searchText);
                            cmd.Parameters.AddWithValue("street", searchText);
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



