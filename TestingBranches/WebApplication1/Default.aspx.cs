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
            DataTable df = DAL.GetCostaInfo();
            DataTable dg = DAL.GetPlestroInfo();
            DataTable dg2 = DAL.GetPlestroInfo();


            gvCustomers.DataSource = dt.DefaultView;
            gvCustomers.DataBind();
            
            CostaGrid.DataSource = df.DefaultView;
            CostaGrid.DataBind();

            gvKeegan.DataSource = dg.DefaultView;
            gvKeegan.DataBind();

            gvKeegan2.DataSource = dg2.DefaultView;
            gvKeegan2.DataBind();

            //KEEGAN WAS HERE TO MAKE A COMMENT


            DAL.CloseConnection();

        }
    }
}