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
    public partial class reject_product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            try
            {
                con.Open();
                string id = Request.QueryString["id"].ToString();
                string sql = "delete from CR_Login where id='" + id + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('User is rejected!!!');</script>");
                Response.Write("<script>window.location='Faculty.aspx';</script>");
                con.Close();

            }
            catch
            {


            }

        }
    }
}