using FreshBooks.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreshBooks.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookDbContext _context;

        public SearchController(BookDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Search()
        {
            var allBooks = await _context.Book.ToListAsync();
            return View(allBooks);
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var allBooks = await _context.Book.ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filterResult = allBooks.Where(x => x.Title.ToLower().Contains(searchString.ToLower())).ToList();

                return View("Search", filterResult);
            }
            return View("Search", allBooks);
        }
    }
}
