using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Semesterprojekt_Datenbank.Utilities
{
    internal class DBUtilityMainWindow /*: IDBUtility<T>*/
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public DataSet Read(string searchText)
        {

            try
            {
                // using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString))

                using (SqlConnection connection = new SqlConnection(DataContext.Leandro_Connection))
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();
                    using (DataTable dataTable = new DataTable("Customer"))
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            "SELECT * from Customer WHERE Name=@Name or Email=@Email or Website=@Website or Street=@Street ", connection))
                        {
                            //cmd.Parameters.AddWithValue("nr", searchText);
                            cmd.Parameters.AddWithValue("name", searchText);  // schaue bei Ihr hier ist der string ansderst
                            cmd.Parameters.AddWithValue("Email", searchText);
                            cmd.Parameters.AddWithValue("website", searchText);
                            cmd.Parameters.AddWithValue("street", searchText);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            adapter.Fill(dataTable);

                            DataSet dataSet = new DataSet();
                            dataSet.Tables.Add(dataTable);



                            return dataSet;
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



