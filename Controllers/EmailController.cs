using FreshBooks.Data.Service;
using FreshBooks.Data.Service.EmailService;
using FreshBooks.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Claims;

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
            string userEmail = User.FindFirstValue(ClaimTypes.Email);
            var request = new EmailDto();
            request.To = email;
            request.Subject = $"Buyer Interest - {orderInformation.BuyerName} - {orderInformation.BookTitle}";
            request.Body = $"Hello Buyer, {orderInformation.BuyerName} is interested in buying the Book you </br>" +
                $"listed Below are the information about the Book the Buyer is interested in </br>" +
                $"{orderInformation.BookTitle}</br>" +
                $"{orderInformation.ISBN}</br>" +
                $"{orderInformation.Author}</br>" +
                $"<img src='{orderInformation.imagesURL}' alt='{orderInformation.BookTitle}' style='width: 100%; max-width: 600px;'/></br>" +
                $"" +
                $"Contact the Buyer with the email addreses him/she/they/them/every other pronunce him/she/they/them/every other pronunce used </br>" +
                $"" +
                $"{userEmail}</br>";

            this.emailService.SendEmail(request);

            //_emailService.SendEmail(request);
            return Ok();

        }
    }
}