using System.Net.Mail;
using System.Web.Configuration;

namespace Hybrid_Saas
{
    public class SendMail
    {
        public static void SendEmail(string name, string email, string message)
        {
            SmtpClient SmtpServer = new SmtpClient(WebConfigurationManager.AppSettings["SMTP"]);
            var mail = new MailMessage();
            mail.From = new MailAddress(email,name);
            mail.To.Add(WebConfigurationManager.AppSettings["EmailTo"]);
            mail.Subject = WebConfigurationManager.AppSettings["EmailSubject"];
            mail.IsBodyHtml = true;
            
            mail.Body = message;
            SmtpServer.Port = int.Parse(WebConfigurationManager.AppSettings["Port"]);
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(WebConfigurationManager.AppSettings["CredentialsEmail"], WebConfigurationManager.AppSettings["CredentialsWachtwoord"]);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}