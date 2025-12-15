using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }=string.Empty;
        [Required(ErrorMessage = "Year is required")]
        [Range(1900, 2025, ErrorMessage ="Year must be between 1900 and 2025")]
        public int? Year { get; set; }
        [Required(ErrorMessage ="Rating is required")]
        [Range(1, 5, ErrorMessage ="Rating must be between 1 and 5")]
        public int? Rating { get; set; }
        [Required(ErrorMessage="Please Enter Genre")]
        public string GenreId { get; set; }= string.Empty;
        [ValidateNever]
        public Genre Genre { get; set; }
    }
}

