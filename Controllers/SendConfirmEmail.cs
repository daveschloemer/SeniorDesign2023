namespace FreshBooks.Controllers;
using FreshBooks.Models;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

public class SendConfirmEmail
{
    private readonly SmtpConfig _smtpConfig;

    public SendConfirmEmail(IOptions<SmtpConfig> smtpConfig)
    {
        _smtpConfig = smtpConfig.Value;
    }

    public void SendConfirmationEmail(string toEmail, string confirmationToken)
    {
        string subject = "UCFreshBooks Confirmation Email";
        string body = "Thank you for signing up for UCFreshBooks!";
        MailMessage message = new MailMessage(_smtpConfig.UserName, toEmail, subject, body);

        SmtpClient client = new SmtpClient(_smtpConfig.Server, _smtpConfig.Port)
        {
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(_smtpConfig.UserName, _smtpConfig.Password),
            EnableSsl = _smtpConfig.EnableSsl
        };

        client.Send(message);
    }
}
