using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Configuration;
using System.Net;


/// <summary>
/// Summary description for SendEmail
/// </summary>
namespace deedback

{
    public static class SendEmail
    {
        public static string Pass, FromEmailid, HostAdd;

        public static void Email_With_CCandBCC(String ToEmail, string cc, String Subj, string Message)
        {
            //Reading sender Email credential from web.config file
            HostAdd = ConfigurationManager.AppSettings["Host"].ToString();
            FromEmailid = ConfigurationManager.AppSettings["FromMail"].ToString();
            Pass = ConfigurationManager.AppSettings["Password"].ToString();
            string A = HostAdd;
            string b = FromEmailid;
            string f = Pass;
            //creating the object of MailMessage
            MailMessage mailMessage = new MailMessage();

            mailMessage.From = new MailAddress(FromEmailid); //From Email Id
            mailMessage.Subject = Subj; //Subject of Email
            mailMessage.Body = Message; //body or message of Email
            mailMessage.IsBodyHtml = true;

            mailMessage.To.Add(new MailAddress(ToEmail)); //reciver's TO Email Id

            mailMessage.CC.Add(new MailAddress(cc)); //Adding CC email Id
            //mailMessage.Bcc.Add(new MailAddress(bcc)); //Adding BCC email Id
            SmtpClient smtp = new SmtpClient(); // creating object of smptpclient
            smtp.Host = HostAdd; //host of emailaddress for example smtp.gmail.com etc

            //network and security related credentials

            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = mailMessage.From.Address;
            NetworkCred.Password = Pass;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            smtp.Send(mailMessage); //sending Email
        }

    }
}