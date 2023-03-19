using Microsoft.AspNetCore.Mvc;

namespace FreshBooks.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
