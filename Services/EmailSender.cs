using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;
using System.Net;

namespace Authentication_Authorization_AddApiEndpoints.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("e906bafb4ddea9", "06deee2cdb96a7"),
                EnableSsl = true
            };
            client.Send("from@example.com", email, subject, htmlMessage);
            return Task.CompletedTask;
        }
    }
}
