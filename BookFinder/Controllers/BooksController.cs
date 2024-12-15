using BookFinder.Interfaces;
using BookFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookFinder.Controllers
{
    public class BooksController : Controller
    {

        public IGoogleBooksService _bookService { get; set; }
        public BooksController(IGoogleBooksService bookService) {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Search");
        }

        public async Task<IActionResult> Search(string BookTitle)
        {   
            BookList response = await _bookService.GetBooks(BookTitle);
            ViewData["BookTitle"] = BookTitle;
            return View(response);
        }

        public async Task<IActionResult> bookDetails(string id)
        {
            Book response = await _bookService.GetBook(id);
            return View(response);
        }
    }
}
