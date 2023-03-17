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

        public async Task<IActionResult> Filter(string searchString)
        {
            var allBooks = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filterResult = allBooks.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();

                return View("Search", filterResult);
            }
            return View("Search", allBooks);
        }
    }
}
