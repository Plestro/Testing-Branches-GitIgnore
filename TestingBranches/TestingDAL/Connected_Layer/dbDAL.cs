using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingDAL.Connected_Layer
{
    public class dbDAL
    {

        private SqlConnection sqlConnection = null;

        public string OpenConnection(string connectionString)
        {
            string result = "";
            sqlConnection = new SqlConnection { ConnectionString = connectionString };

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                result = $"{ex.Message.ToString()}";
            }

            return result;
        }

        public void CloseConnection()
        {
            sqlConnection.Close();
        }

        public DataTable GetCustomerInfo()
        {
            DataTable dt = new DataTable();
            string query = "Select * from CustomerTbl";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }


            return dt;
         

        }

        public DataTable GetCostaInfo()
        {
            DataTable dt = new DataTable();
            string query = "Select * from tblMergeDemo";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }


            return dt;


        }

        public DataTable GetPlestroInfo()
        {
            DataTable dt = new DataTable();
            string query = "Select * from tblMergeDemo";

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    reader.Close();
                }

            }
            catch (Exception)
            {

                throw;
            }


            return dt;


        }
    }
}
