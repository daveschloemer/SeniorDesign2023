using Microsoft.AspNetCore.Mvc;

namespace FreshBooks.Controllers
{
    public class SellController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
