using FreshBooks.Data;
using FreshBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FreshBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BookDbContext _context;

        public HomeController(BookDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Home()
        {
            var allBooks = await _context.Book.ToListAsync();
            var firstThree = allBooks.Take(3);
            return View(firstThree);
        }
        [HttpGet("SignUp")]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpGet("Request")]
        public IActionResult Request()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}