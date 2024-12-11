using Microsoft.AspNetCore.Mvc;

namespace BookFinder.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string BookTitle)
        {
            ViewData["BookTitle"] = BookTitle;
            return View();
        }
    }
}
