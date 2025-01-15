namespace BookFinder.Models
{
    public record class Book
    {
        public string id { get; set; }
        public BookInfo volumeInfo { get; set; }
        public saleInfo? saleInfo { get; set; }
    }

    public record class BookInfo
    {
        public string  title { get; set; } 
        public List<string> authors { get; set; }
        public string publisher { get; set; }
        public string publishedDate { get; set; }
        public string description { get; set; }
        public int pageCount { get; set; }
        public imageLinks? imageLinks { get; set; }
        public string? previewLink { get; set; } 
    }
    public record class imageLinks
    {
        public string smallThumbnail { get; set; }
        public string thumbnail { get; set; }
    }

    public record class saleInfo
    {
        public string? buyLink { get; set; }
        public bool isEbook { get; set; }
        public string saleability {  get; set; }
        public string country { get; set; }
    }
}
