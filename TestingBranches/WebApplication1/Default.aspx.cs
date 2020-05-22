using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingDAL.Connected_Layer;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        string connString =
       ConfigurationManager.ConnectionStrings["Testing"].ConnectionString;

        // Create our DAL object.
        dbDAL DAL = new dbDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //loaddata
                LoadData();
            }
        }

        protected void LoadData()
        {

            DAL.OpenConnection(connString);

            DataTable dt = DAL.GetCustomerInfo();
            DataTable dg = DAL.GetPlestroInfo();

            gvCustomers.DataSource = dg.DefaultView;
            gvCustomers.DataBind();

            KeeganDemo.DataSource = dt.DefaultView;
            KeeganDemo.DataBind();

            DAL.CloseConnection();

        }
    }
}