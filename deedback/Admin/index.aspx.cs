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
    public partial class index : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                
                Response.Redirect("../index.aspx");
            }
            if (!Page.IsPostBack)
            {
                Loadcounts();
            }
        }
        private void Loadcounts()
        {
            string sql = "Select Count(id) from CR_Login where utype='Alumini' and status='Approved'";


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                Label1.Text = Convert.ToString(count);
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {

            }

            string sql2 = "Select Count(id) from CR_Login where utype='Faculty' and status='Approved'";


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql2, con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                Label2.Text = Convert.ToString(count);
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {

            }


            string sql3 = "Select Count(id) from CR_Login where utype='Current' and status='Approved'";


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql3, con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                Label3.Text = Convert.ToString(count);
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {

            }



            string sql4 = "Select sum(cast(Amount as int) ) from CR_Donation " ;


            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql4, con);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                Label4.Text = Convert.ToString(count);
                cmd.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {

            }
        }
    }
}