using FreshBooks.Data;
using FreshBooks.Data.Service;
using FreshBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FreshBooks.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IBookService _service;

        public CatalogController(IBookService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Catalog()
        {
            var allBooks = await _service.GetAllAsync();
            return View(allBooks);
        }

        //Get: Books Detail

        public async Task<IActionResult> Details(int id)
        {
            var booksDetail = await _service.GetBookAsync(id);
            return View(booksDetail);
        }

        //Get: Catalog/Create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Well to FreshBook";
            ViewBag.Description = "Sell Used Books here";
            return View();
        }


        public async Task<IActionResult> Filter(string searchString)
        {
            var allBooks = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filterResult = allBooks.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();

                return View("Catalog", filterResult);
            }
            return View("Catalog", allBooks);
        }
        [HttpGet("RequestSuccess")]
        public IActionResult RequestSuccess()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            string userEmail = User.FindFirstValue(ClaimTypes.Email);
            string userName = User.FindFirstValue(ClaimTypes.Name);
            await _service.AddNewBookAsync(book, userId, userEmail, userName);

            return View("RequestSuccess");
        }

        public async Task<IActionResult> MyListing()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var allBooks = await _service.GetBooksByUserIdAsync(userId);
            return View(allBooks);
        }
    }


}
