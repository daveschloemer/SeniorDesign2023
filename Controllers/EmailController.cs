using FreshBooks.Models;
using FreshBooks.Services.EmailService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;
        public EmailController(IEmailService emailService)
        {
            this.emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail([FromForm] OrderViewModel orderInformation)
        {
            // get the book id from the request, look up book by the book id
            // get the seller from the book, pull seller's email, and use it as request.To = seller email

            var request = new EmailDto();
            request.To = orderInformation.Email;
            request.Subject = $"Buyer Interest - {orderInformation.Name} - {orderInformation.Number}";
            request.Body = "Book looks cool, I want it";

            this.emailService.SendEmail(request);

            //_emailService.SendEmail(request);
            return Ok();

        }
    }
}
