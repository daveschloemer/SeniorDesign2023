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
            request.Body = $"Hello, </br></br> " +
                $"{orderInformation.BuyerName} is interested in buying a book that you have listed. </br>" +
                $"<h4>Book Information:</h4> </br>" +
                $"<b>Title:</b> {orderInformation.BookTitle}</br>" +
                $"<b>ISBN:</b> {orderInformation.ISBN}</br>" +
                $"<b>Author:</b> {orderInformation.Author}</br></br>" +
                $"<img src='{orderInformation.imagesURL}' alt='{orderInformation.BookTitle}' style='width: 50%; max-width: 300px;'/></br></br>" +
                $"" +
                $"Please contact the buyer with the listed email: {userEmail} </br></br>" +
                $"" +
                $"The buyer has requested to meet at the following location: {orderInformation.Location} </br></br>" +
                $"" +
                $"If the book is no longer available, please login and remove it from your listing.</br></br>" +
                $"" +
                $"To remove the textbook from your listings page:</br>" +
                $"" +
                $"Click on your profile -> My Listing -> Find your Book -> Click on remove listing</br></br>" +
                $"" +
                $"Thanks!</br></br>" +
                $"" +
                $"The FreshBooks Team";

            this.emailService.SendEmail(request);

            return RedirectToAction("MessageSent", "Home");
        }
    }
}
