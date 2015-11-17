using System.Net.Mail;
using System.Web.Configuration;

namespace Hybrid_SaaS
{
    public class SendMail
    {
        public static void SendEmail(string name, string email, string message)
        {
            SmtpClient SmtpServer = new SmtpClient(WebConfigurationManager.AppSettings["Mail smtpserver"]);
            var mail = new MailMessage();
            mail.From = new MailAddress(email,name);
            mail.To.Add(WebConfigurationManager.AppSettings["Mail recipient"]);
            mail.Subject = WebConfigurationManager.AppSettings["Mail subject"];
            mail.IsBodyHtml = true;
            
            mail.Body = message;
            SmtpServer.Port = int.Parse(WebConfigurationManager.AppSettings["Mail smtpserver port"]);
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(WebConfigurationManager.AppSettings["Mail smtpserver user"], WebConfigurationManager.AppSettings["Mail smtp password"]);
            SmtpServer.EnableSsl = false;
            SmtpServer.Send(mail);
        }
    }
}