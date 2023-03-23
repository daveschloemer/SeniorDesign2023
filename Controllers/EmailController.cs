using FreshBooks.Data.Service;
using FreshBooks.Data.Service.EmailService;
using FreshBooks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FreshBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService emailService;
        private readonly IBookService _service;
        public EmailController(IEmailService emailService, IBookService service)
        {
            this.emailService = emailService;
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromForm] OrderViewModel orderInformation)
        {
            // get the book id from the request, look up book by the book id
            // get the seller from the book, pull seller's email, and use it as request.To = seller email
            var booksDetail = await _service.GetBookAsync(orderInformation.BookID);
            var email = booksDetail.Email;
            var request = new EmailDto();
            request.To = email;
            request.Subject = $"Buyer Interest - {orderInformation.BuyerName} - {orderInformation.BookID}";
            request.Body = "Book looks cool, I want it";

            this.emailService.SendEmail(request);

            //_emailService.SendEmail(request);
            return Ok();

        }
    }
}