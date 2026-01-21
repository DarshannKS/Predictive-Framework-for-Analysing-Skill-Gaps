using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback
{
    public partial class alumini : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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


                SQL = "insert into CR_Login";
                SQL += "           ([FirstName]";
                SQL += "           ,[EmailID]";
                SQL += "           ,[Password]";
                SQL += "           ,[Mobile]";
                SQL += "           ,[addresses]";
                SQL += "           ,[Company]";
                SQL += "           ,[branch]";
                SQL += "           ,[status]";
                SQL += "           ,[utype]";
                SQL += "           ,[POY])";
                SQL += " values";
                SQL += "           ('" + (uname.Value) + "'";
                SQL += "           ,'" + (email.Value) + "'";
                SQL += "           ,'" + (pswd.Value) + "'";
                SQL += "           ,'" + (phn.Value) + "' ";
                SQL += "           ,'" + (ads.Value) + "'";
                SQL += "           ,'" + (industray.Value) + "'";
                SQL += "           ,'" + (branch.Value) + "'";
             
                SQL += "           ,'Pending'";
       
                SQL += "           ,'Alumini'";
                SQL += "           ,'" + (pot.Value) + "'";
                //SQL += "           ,'" + (gender.Value) + "' ";
                SQL += ")";
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                try
                {
                    MailMessage m = new MailMessage("secureimg1@gmail.com", email.Value, "Welcome Mail !!!", "​Welcome to the Alumini Application !!!\n Your User  name : " + uname.Value + "\n Your Password is: " + pswd.Value + "");
                    SmtpClient s = new SmtpClient("smtp.gmail.com", 587);
                    s.EnableSsl = true;
                    s.UseDefaultCredentials = false;
                    s.Credentials = new System.Net.NetworkCredential("secureimg1@gmail.com", "fgnrwzfkrnbupjwg");
                    s.EnableSsl = true;
                    s.Send(m);
                    Console.WriteLine("Mail Sent");
                }
                catch
                {
                }
                Response.Write("<script>alert('Thank you for registering with us!!!');</script>");
                Response.Write("<script>window.location='login.aspx';</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Email Already Existsing with us!!!');</script>");
            }
            finally
            {
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}