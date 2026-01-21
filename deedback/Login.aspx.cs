using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            if (uname.Value.Equals(string.Empty) | pswd.Value.Equals(string.Empty))
            {
                Response.Write("<script>alert('Please enter the details!!!');</script>");
            }
            else
            {
                if (uname.Value.Equals("admin") & pswd.Value.Equals("admin"))
                {
                    Session["Username"] = uname.Value;
                    Response.Redirect("Admin/index.aspx");
                }
                SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConStr"]);
                try
                {
                    con.Open();
                    string query = "select * from CR_Login where EmailID='" + uname.Value + "' and Password='" + pswd.Value + "' and status='Approved'; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string un = dr.GetValue(0).ToString();
                            string pd = dr.GetValue(1).ToString();
                            string utype = dr.GetValue(16).ToString();

                            Session["Username"] = uname.Value;
                            Session["name"] = dr.GetValue(1).ToString();

                            if (utype == "Alumini")
                            {
                                Session["Username"] = uname.Value;

                                Session["uid"] = dr.GetValue(0).ToString();
                                Session["nme"] = dr.GetValue(1).ToString();
                                Response.Write("<script>window.location='Alumini/index.aspx';</script>");
                            }
                            if (utype == "Faculty")
                            {
                                Session["Username"] = uname.Value;

                                Session["uid"] = dr.GetValue(0).ToString();
                                Response.Write("<script>window.location='Faculty/index.aspx';</script>");
                            }
                            else
                            {
                                Session["Username"] = uname.Value;

                                Session["id"] = dr.GetValue(0).ToString();

                                Session["usn"] = dr.GetValue(22).ToString();

                                Session["uid"] = dr.GetValue(0).ToString();
                                Response.Write("<script>window.location='Current/default.aspx';</script>");
                            }

                            //Response.Redirect("dashboard/index.aspx");

                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid User!!!');</script>");
                    }
                }
                catch
                {
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}