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
    public partial class approve_product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            try
            {
                con.Open();
                string id = Request.QueryString["id"].ToString();
                string sql = "update CR_Login set status='Approved' where id='" + id + "' ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
               


                string sql1 = "Select utype from CR_Login where id='" + id + "'";
                con.Close();

                try
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    string usetype = Convert.ToString(cmd1.ExecuteScalar());
                    //string  = Convert.ToString(count);
                    cmd.Dispose();
                    con.Close();

                    if(usetype=="Alumini")
                    {
                        Response.Write("<script>alert('User is approved!!!');</script>");
                        Response.Write("<script>window.location='Faculty.aspx';</script>");
                    }   if(usetype=="Faculty")
                    {
                        Response.Write("<script>alert('User is approved!!!');</script>");
                        Response.Write("<script>window.location='Faculty.aspx';</script>");
                    }  else
                    {
                        Response.Write("<script>alert('User is approved!!!');</script>");
                        Response.Write("<script>window.location='Current.aspx';</script>");
                    }

                }
                catch (Exception ex)
                {

                }

                
                con.Close();

            }
            catch
            {


            }

        }
    }
}