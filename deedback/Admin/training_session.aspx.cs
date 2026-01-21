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
    public partial class training_session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Unnamed_ServerClick1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Constr"]);
            try
            {
                string a = "";
                if (FileUpload1.HasFile)
                {
                    string path = Server.MapPath(@"../upload/");


                    string extension = System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName);

                    a = DateTime.Now.ToFileTime() + extension;
                    FileUpload1.SaveAs(path + a);
                    string imgs = path + a;



                }


                con.Open();
                Random r = new Random();
                String str = "Usr" + r.Next(123, 9999);
                string IPAddress = HttpContext.Current.Request.UserHostAddress;
                string SQL = "";
                // string ComId = Session["cid"].ToString();
                string ComId = "4";

                SQL = "insert into CR_Training";

                SQL += "           ([Training_Concept]";
                SQL += "           ,[Training_Details]";
                SQL += "           ,[Trainer_name]";
                SQL += "           ,[Training_Starts_from]";
                SQL += "           ,[Contact_number]";
                SQL += "           ,[File])";


                SQL += " values";
                SQL += "           ('" + (tc.Value) + "'";
                SQL += "           ,'" + (tdetails.Value) + "'";
                SQL += "           ,'" + (tname.Value) + "'";
                SQL += "           ,'" + (Text1.Value) + "'";
                SQL += "           ,'" + (TextBox1.Text) + "'";
                SQL += "           ,'" + (a) + "'";






                SQL += ")";
                SqlCommand cmd = new SqlCommand(SQL, con);
                cmd.ExecuteNonQuery();
                try
                {

                    //MailMessage m = new MailMessage("gangothrdipdcprincipal@gmail.com", Cemail.Value, "Welcome Mail !!!", "​Welcome to the Food Network Application !!!\n Your User  name : " + Cemail.Value + "\n Your Password is: " + Cemail.Value + "");
                    //SmtpClient s = new SmtpClient("smtp.gmail.com", 587);
                    //s.EnableSsl = true;
                    //s.UseDefaultCredentials = false;
                    //s.Credentials = new System.Net.NetworkCredential("gangdothrdipucprincipal@gmail.com", "vumehscxirxcwarq");
                    //s.EnableSsl = true;
                    //s.Send(m);
                    //Console.WriteLine("Mail Sent");
                }
                catch (Exception ex)
                {
                }
                Response.Write("<script>alert('Training session uploaded Successfully!!!');</script>");
                Response.Write("<script>window.location='view_Training.aspx';</script>");
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }

        }

        //protected void Unnamed_ServerClick1(object sender, EventArgs e)
        //{

        //}
    }
}