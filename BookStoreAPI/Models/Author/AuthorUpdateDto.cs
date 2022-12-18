using AutoMapper;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace BookStoreAPI.Models.Author
{
    public class AuthorUpdateDto : BaseDto
    {
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [System.ComponentModel.DataAnnotations.Required]
        [StringLength(250)]
        public string Bio { get; set; }
    }
}
