using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebAssignemnt.Models
{
    public class BlogModel
    {
        [Key]
        [HiddenInput]
        public int  BlogID { get; set; }


        [Required(ErrorMessage = "Please enter title.")]
        [MinLength(2, ErrorMessage = "Title should be atleast 2 characters.")]
        [MaxLength(50, ErrorMessage = "This field takes only maximum of 50 characters.")]
        public string Title { get; set; }

        [MinLength(10, ErrorMessage = "Content should be atleast 10 characters.")]
        [MaxLength(1000, ErrorMessage = "This field takes only maximum of 1000 characters.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Please Select an author from list.")]
        public string Author { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publish Date")]
        public DateTime PublishDate { get; set; }


    }
}
