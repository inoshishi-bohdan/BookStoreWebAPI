using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models.Book
{
    public class BookCreateDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(80)]
        public string Title { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Range(1500, int.MaxValue)]
        public int Year { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Isbn { get; set; } = null!;
        [System.ComponentModel.DataAnnotations.Required]
        public string Summary { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        public string Image { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [Range(0, int.MaxValue)]
        public decimal Price { get; set; }
        public int AuthorId { get; set; }
    }
}
