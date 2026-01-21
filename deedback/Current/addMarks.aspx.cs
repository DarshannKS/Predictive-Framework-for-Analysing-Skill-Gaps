using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace deedback.Current
{
    public partial class addMarks : System.Web.UI.Page
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
                string usn = Session["usn"].ToString();
                string sts = "Pending";

                SQL = "insert into CR_Mark";

                SQL += "           ([CourseName]";
                SQL += "           ,[CourseSem]";
                SQL += "           ,[StdUSN]";
                SQL += "           ,[Status]";
                SQL += "           ,[marks]";
                SQL += "           ,[File])";


                SQL += " values";
                SQL += "           ('" + (Text1.Value) + "'";
                SQL += "           ,'" + (Select1.Value) + "'";
                SQL += "           ,'" + (usn) + "'";
                SQL += "           ,'" + (sts) + "'";
                SQL += "           ,'" + (sgpa.Value) + "'";
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
                Response.Write("<script>alert('Marks added Successfully!!!');</script>");
                Response.Write("<script>window.location='viewMarks.aspx';</script>");
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