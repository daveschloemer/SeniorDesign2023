using FreshBooks.Data;
using FreshBooks.Data.Service;
using FreshBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FreshBooks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IBookService _service;

        public HomeController(IBookService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Home()
        {
            var allBooks = await _service.GetAllAsync();
            var firstThree = allBooks.Take(3);
            return View(firstThree);
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