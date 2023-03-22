using FreshBooks.Data.Service;
using FreshBooks.Data.Tab;
using FreshBooks.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FreshBooks.Controllers
{
    public class ListedController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ListedTab _listedTab;

        public ListedController(IBookService bookService, ListedTab listedTab)
        {
            _bookService = bookService;
            _listedTab = listedTab;

        }
        public IActionResult Index()
        {
            var items = _listedTab.GetListedTabItems();
            _listedTab.ListedTabItems = items;
            var response = new ListedTabVM()
            {
                ListedTab = _listedTab,

            };
            return View(response);
        }
    }
}
