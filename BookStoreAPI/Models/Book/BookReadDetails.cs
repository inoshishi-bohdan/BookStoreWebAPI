namespace BookStoreAPI.Models.Book
{
    public class BookReadDetails : BaseDto
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Isbn { get; set; } = null!;
        public string Summary { get; set; }
        public string Image { get; set; }
        public int AuthorId { get; set; }
        public decimal Price { get; set; }
        public virtual string AuthorName { get; set; }
    }
}
