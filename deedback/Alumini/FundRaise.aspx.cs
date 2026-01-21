using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Alumini
{
    public partial class FundRaise : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {

                Response.Redirect("../index.aspx");
            }
            if (!Page.IsPostBack)
            {
                //Loadcounts();
            }
        }
        protected void Unnamed_ServerClick1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            try
            {
                con.Open();
                Random r = new Random();
                String trd = r.Next(123, 9999).ToString();
                string IPAddress = HttpContext.Current.Request.UserHostAddress;
                string SQL = "";
                string uid = "daya123";

                SQL = "insert into CR_Donation";
                SQL += "           ([FirstName]";
                SQL += "           ,[CardNumber]";
                SQL += "           ,[Amount]";

                SQL += "           ,[Uid]";

                SQL += "           ,[Tid])";
        
                SQL += "values";
                SQL += "           ('" + (cname.Value) + "'";
                SQL += "           ,'" + (ccnum.Value) + "'";
                SQL += "           ,'" + (amt.Value) + "'";
   
                SQL += "           ,'" + (uid) + "'";

                SQL += "           ,'" + (trd) + "'";

   
                //SQL += "           ,'" + (gender.Value) + "' ";
                SQL += ")";
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                try
                {
                    //MailMessage m = new MailMessage("foodnet2020@gmail.com", email.Value, "Welcome Mail !!!", "​Welcome to the Food Network Application !!!\n Your User  name : " + uname.Value + "\n Your Password is: " + pswd.Value + "");
                    //SmtpClient s = new SmtpClient("smtp.gmail.com", 587);
                    //s.Credentials = new System.Net.NetworkCredential("foodnet2020@gmail.com", "admin@foodnet");
                    //s.EnableSsl = true;
                    //s.Send(m);
                    //Console.WriteLine("Mail Sent");
                }
                catch
                {
                }
                Response.Write("<script>alert('Thank you for donating!!!');</script>");
                Response.Write("<script>window.location='index.aspx';</script>");
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('Email Already Existsing with us!!!');</script>");
            }
            finally
            {
                con.Close();
            }
        }

        //protected void Unnamed_ServerClick1()
        //{

        //}
    }
}