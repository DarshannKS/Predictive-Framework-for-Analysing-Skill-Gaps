using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Admin
{
    public partial class Faculty : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {

                Response.Redirect("../index.aspx");
            }
            if (!Page.IsPostBack)
            {
                loaddata();
            }
        }
        private void loaddata()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            cmd.Connection = con;
            cmd.CommandText = "select * from CR_Login Where utype='Faculty' and status='Pending'";
            con.Open();
            RepeatInformation.DataSource = cmd.ExecuteReader();
            RepeatInformation.DataBind();
            con.Close();
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {

        }
    }
}