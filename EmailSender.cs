using System.Net;
using System.Net.Mail;

namespace AppSec_Assignment
{
    public class EmailSender 
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "testemail@gmail.com";
            var password = "ABcd12345678";

            var client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, password)

            };

            return client.SendMailAsync(from: mail, recipients: email, subject, message);
        }
    }
}
