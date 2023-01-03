namespace TheBookstown.Models
{
    public class BookViewModel
    {
        public Guid BookId { get; set; }
        public string? BookName { get; set; }
        public string? BookAuthorName { get; set; }
        public int BookPrice { get; set; }
        public string? BookGenreName { get; set; }
    }
}
