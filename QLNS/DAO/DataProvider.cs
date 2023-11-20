using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }; return instance;
            }
            private set => instance = value;
        }
        private DataProvider() { }

        public DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();
            DataSet ds = new DataSet();
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLNS1;Integrated Security=True"))
            {
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                int j = 0;
                try
                {
                    for (int i = 0; i < 10; i++)
                    {
                        data= ds.Tables[i];
                        j = i;
                    }
                }
                catch (Exception)
                {
                    data = ds.Tables[j];
                }
                connection.Close();
            }
            return data;
        }
        public int ExcuteNonQuery(string query)
        {
            int data = 1;
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLNS1;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExcuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLNS1;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
