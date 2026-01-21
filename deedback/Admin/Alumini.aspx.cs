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
    public partial class Alumini : System.Web.UI.Page
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
            cmd.CommandText = "select * from CR_Login Where utype='Alumini' and status='Pending'";
            con.Open();
            RepeatInformation.DataSource = cmd.ExecuteReader();
            RepeatInformation.DataBind();
            con.Close();
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod()]
        public static int AluminDelete(string JID)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            string sql = "";
            con.Open();
            sql = "delete from CR_Login where id='" + JID + "'";
            //sql = "insert into [SMTW_MyJob] (cid,uid,jobid,Name,Email,status)values('" + Cid + "','" + uid + "','" + JID + "','" + Name + "','" + Email + "','applied')";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (cmd.ExecuteNonQuery() > 0)

                return 1;
            return 0;
            con.Close();
        }
    }
}