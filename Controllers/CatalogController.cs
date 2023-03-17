using FreshBooks.Data;
using FreshBooks.Data.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        //Get: Create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Well to FreshBook";
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
    }
}
