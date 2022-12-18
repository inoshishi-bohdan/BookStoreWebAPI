using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models.Author
{
    public class AuthorReadDto : BaseDto
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Bio { get; set; }
    }
}
