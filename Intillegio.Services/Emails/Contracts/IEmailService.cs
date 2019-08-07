namespace Intillegio.Services.Emails.Contracts
{
    public interface IEmailService
    {
        void Send(IEmailMessage emailMessage);
    }
}
