using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestingBranches
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
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

            sqlConnection.Close();

        }
    }
}