using System;
using Intillegio.Services.Emails.Contracts;
using MimeKit;

namespace Intillegio.Services.Emails
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;

        public EmailService(IEmailConfiguration emailConfiguration)
        {
            this._emailConfiguration = emailConfiguration;
        }

        public void Send(IEmailMessage emailMessage)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(emailMessage.Name, _emailConfiguration.SmtpUsername));
            message.To.Add(new MailboxAddress("vels", "velizar.velikov@gmail.com"));
            message.Subject = $"{emailMessage.Subject}";
            message.Body = new TextPart("plain")
            {
                Text = $"Message: {emailMessage.Content}" + Environment.NewLine +
                       $"Contact email: {emailMessage.Email}",
            };

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(_emailConfiguration.SmtpServer, _emailConfiguration.SmtpPort, false);
                client.Authenticate(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
