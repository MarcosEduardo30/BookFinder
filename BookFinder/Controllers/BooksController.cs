using BookFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookFinder.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Search");
        }

        public async Task<IActionResult> Search(string BookTitle)
        {
            //Essa parte do código está aqui somente de forma provisória
            HttpClient HttpClient = new HttpClient() { BaseAddress = new Uri("https://www.googleapis.com/books/v1/") };
            var response = await HttpClient.GetFromJsonAsync<BookList>($"volumes?q=+intitle:{BookTitle}&maxResults=15");
            ViewData["BookTitle"] = BookTitle;
            return View(response);
        }
    }
}
