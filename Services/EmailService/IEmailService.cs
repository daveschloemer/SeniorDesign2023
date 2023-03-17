using FreshBooks.Models;

namespace FreshBooks.Services.EmailService
{
    public interface IEmailService
    {
       void SendEmail(EmailDto request);
    }
}
