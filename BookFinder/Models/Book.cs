namespace BookFinder.Models
{
    public record class Book
    {
        public string id { get; set; }
        public BookInfo volumeInfo { get; set; }
    }

    public record class BookInfo
    {
        public string  title { get; set; } 
        public List<string> authors { get; set; }
        //public DateTime publishedDate { get; set; }
        public string description { get; set; }
    }
}
