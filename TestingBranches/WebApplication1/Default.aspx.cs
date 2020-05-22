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

            gvCustomers.DataSource = dt.DefaultView;
            gvCustomers.DataBind();

            CostaGrid2.DataSource = df.DefaultView;
            CostaGrid2.DataBind();

            CostaGrid.DataSource = df.DefaultView;
            CostaGrid.DataBind();



            gvKeegan.DataSource = dg.DefaultView;
            gvKeegan.DataBind();

            gvKeegan2.DataSource = dg.DefaultView;
            gvKeegan2.DataBind();

            gvKeegan3.DataSource = dg.DefaultView;
            gvKeegan3.DataBind();

        //rerehgergergherg
        //sghdhdfhbdbdfrb



            DAL.CloseConnection();

        }

        public void Test()
        {

        }
    }
}