using FreshBooks.Models;

namespace FreshBooks.Data.Service.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
