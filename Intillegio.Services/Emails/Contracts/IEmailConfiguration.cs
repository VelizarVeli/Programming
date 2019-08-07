namespace Intillegio.Services.Emails.Contracts
{
    public interface IEmailConfiguration
    {
        string SmtpServer { get; }

        int SmtpPort { get; }

        string SmtpUsername { get; set; }

        string SmtpPassword { get; set; }
    }
}
