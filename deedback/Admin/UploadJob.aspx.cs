using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Admin
{
    public partial class UploadJob : System.Web.UI.Page
    {
     

            protected void Page_Load(object sender, EventArgs e)
            {

                string ComId = Session["Username"].ToString();
            }

            protected void Unnamed_ServerClick(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
                try
                {
                    con.Open();
                    Random r = new Random();
                    String str = "Usr" + r.Next(123, 9999);
                    string IPAddress = HttpContext.Current.Request.UserHostAddress;
                    string SQL = "";
                    string ComId = Session["Username"].ToString();

                    SQL = "insert into SMTW_JobData";
                    SQL += "           ([Cname]";
                    SQL += "           ,[Cemail]";
                    SQL += "           ,[Mobile]";
                    SQL += "           ,[JobTitle]";
                    SQL += "           ,[ClsDate]";
                    SQL += "           ,[Skills]";

                    SQL += "           ,[Cavil]";
                    SQL += "           ,[loc]";
                    SQL += "           ,[desc]";
                    SQL += "           ,[Status]";
                    SQL += "           ,[CompID]";


                    SQL += "           ,[IpAddress])";

                    SQL += " values";
                    SQL += "           ('" + (Cname.Value) + "'";
                    SQL += "           ,'" + (Cemail.Value) + "'";
                    SQL += "           ,'" + (phn.Value) + "'";
                    SQL += "           ,'" + (JobTitle.Value) + "'";
                    SQL += "           ,'" + (clsDate.Value) + "'";
                    SQL += "           ,'" + (Skilles.Value) + "'";


                    SQL += "           ,'" + (Cavil.Value) + "'";

                    SQL += "           ,'" + (loc.Value) + "' ";
                    SQL += "           ,'" + (desc.Value) + "'";
                    SQL += "           ,'Approved'";
                    SQL += "           ,'" + ComId + "'";


                    SQL += "           ,'" + IPAddress + "' ";

                    SQL += ")";
                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.ExecuteNonQuery();
                    try
                    {

                        MailMessage m = new MailMessage("gangothripucprincipal@gmail.com", Cemail.Value, "Welcome Mail !!!", "​Welcome to the Food Network Application !!!\n Your User  name : " + Cemail.Value + "\n Your Password is: " + Cemail.Value + "");
                        SmtpClient s = new SmtpClient("smtp.gmail.com", 587);
                        s.EnableSsl = true;
                        s.UseDefaultCredentials = false;
                        s.Credentials = new System.Net.NetworkCredential("gangothripucprincipal@gmail.com", "vumehscxirxcwarq");
                        s.EnableSsl = true;
                        s.Send(m);
                        Console.WriteLine("Mail Sent");
                    }
                    catch (Exception ex)
                    {
                    }
                    Response.Write("<script>alert('Job uploaded with us!!!');</script>");
                    Response.Write("<script>window.location='ManageJob.aspx';</script>");
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }

            }
        }
    }