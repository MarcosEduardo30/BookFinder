using BookFinder.Interfaces;
using BookFinder.Models;

namespace BookFinder.Services
{
    public class GoogleBooksService: IGoogleBooksService
    {
        public async Task<BookList> GetBooks(string searchString)
        {
            using (HttpClient HttpClient = new HttpClient() { BaseAddress = new Uri("https://www.googleapis.com/books/v1/") })
            {
                return await HttpClient.GetFromJsonAsync<BookList>($"volumes?q=+intitle:{searchString}&maxResults=9");
            };
        }

        public async Task<Book> GetBook(string id)
        {
            using (HttpClient HttpClient = new HttpClient() { BaseAddress = new Uri("https://www.googleapis.com/books/v1/") })
            {
                return await HttpClient.GetFromJsonAsync<Book>($"volumes/{id}");
            };
        }
    }
}
