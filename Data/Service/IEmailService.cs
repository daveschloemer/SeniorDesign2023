
using FreshBooks.Models;

namespace FreshBooks.Data.Service
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
