using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using deedback;


namespace deedback
{
    public partial class Register : System.Web.UI.Page
    {
        protected string toEmail, EmailSubj, EmailMsg, ccId, bccId;

        //protected void Unnamed_ServerClick(object sender, EventArgs e)
        //{

        //}

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_ServerClick1(object sender, EventArgs e)
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
       
                SQL += "           ,'" + (branch.Value) + "'";
              
                SQL += "           ,'Pending'";
                SQL += "           ,'Current'";
                SQL += "           ,''";
                //SQL += "           ,'" + (gender.Value) + "' ";
                SQL += ")";
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                try
                {
                    //string Subject = "Your confirmation and event pass for AWS Initiate Day – Partner Forum";
                    //string mailMessage = "";
                    //var _HostLink = ConfigurationManager.AppSettings["HOSTLink"];
                    //mailMessage += "";
                    //mailMessage += "<p>";
                    //mailMessage += "Hi " + uname.Value + ",</p>";
                    //mailMessage += "<p></p>";
                    //mailMessage += "<p>Do carry a copy of this mail to the event</p>";
                    //mailMessage += "<p>We look forward to welcoming you!</p>";
                    //mailMessage += "<p>Warm Regards,<br />";
                    //mailMessage += "Team AWS India (AISPL)</p>";
                    //mailMessage += "<p>&nbsp;</p>";
                    //mailMessage += "<p>&nbsp;</p>";
                    //toEmail = email.Value;
                    //EmailMsg = "";
                    //ccId = "mani@gmail.com";
                    //bccId = "";
                    //SendEmail.Email_With_CCandBCC(toEmail, ccId, Subject, mailMessage);

                    MailMessage m = new MailMessage("secureimg1@gmail.com", email.Value, "Welcome Mail !!!", "​Welcome to the alumini Application !!!\n Your User  name : " + uname.Value + "\n Your Password is: " + pswd.Value + "");
                    SmtpClient s = new SmtpClient("smtp.gmail.com", 587);
                    s.EnableSsl = true;
                    s.UseDefaultCredentials = false;
                    s.Credentials = new System.Net.NetworkCredential("secureimg1@gmail.com", "fgnrwzfkrnbupjwg");
                    s.EnableSsl = true;
                    s.Send(m);
                    Console.WriteLine("Mail Sent");
                }
                catch (Exception ex)
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

        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}