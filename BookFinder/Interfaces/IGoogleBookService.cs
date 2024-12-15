using BookFinder.Models;

namespace BookFinder.Interfaces
{
    public interface IGoogleBooksService
    {
        public Task<BookList> GetBooks(string searchString);

        public Task<Book> GetBook(string bookId);
    }
}
