namespace BookFinder.Models
{
    public record class BookList
    {
        public int totalItems { get; set; }
        public List<Book> items { get; set; }
    }
}
