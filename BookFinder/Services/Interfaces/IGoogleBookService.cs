using BookFinder.Models;

namespace BookFinder.Services.Interfaces
{
    public interface IGoogleBooksService
    {
        public Task<BookList> GetBooks(string searchString);

        public Task<Book> GetBook(string bookId);
    }
}
