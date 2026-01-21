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
    public partial class ManageJob : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["Username"] == null)
            //{

            //    Response.Redirect("../index.aspx");
            //}
            loaddata();
            string ComId = Session["Username"].ToString();
            if (!Page.IsPostBack)
            {
                loaddata();
            }
        }
        private void loaddata()
        {
            string ComId = Session["Username"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            cmd.Connection = con;
            cmd.CommandText = "select * from SMTW_JobData where CompID='" + ComId + "'  ";
            con.Open();
            RepeatInformation.DataSource = cmd.ExecuteReader();
            RepeatInformation.DataBind();
            con.Close();
        }
        [System.Web.Services.WebMethod()]
        public static int deleteClaim(string ID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            con.Open();
            string sql = "";
            sql = "Delete from SMTW_JobData where id = " + ID;
            SqlCommand cmd = new SqlCommand(sql, con);
            if (cmd.ExecuteNonQuery() > 0)
                return 1;
            return 0;

            con.Close();
        }


    }
}