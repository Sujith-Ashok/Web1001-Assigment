using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebAssignemnt.Models
{
    public class AuthorModel
    {

        [Key]
        [HiddenInput]
        public int ID { get; set; }


        [Required(ErrorMessage = "Please enter first name.")]
        [Display(Name = "Given Name")]
        [MinLength(2, ErrorMessage = "Name should be atleast 2 characters.")]
        [MaxLength(20, ErrorMessage = "This field takes only maximum of 20 characters.")]
        public string GivenName { get; set; }

        
        [Required(ErrorMessage = "Please enter last name.")]
        [Display(Name = "Last Name")]
        [MinLength(2, ErrorMessage = "Name should be atleast 2 characters.")]
        [MaxLength(20, ErrorMessage = "This field takes only maximum of 20 characters.")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Please enter valid email address.")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Url]
        [Display(Name = "Website Address")]
        public string WebsiteAddress { get; set; }

        [Phone]
        [Display(Name = "Telephone Number")]
        [MinLength(10, ErrorMessage = "Phone number should be atleast 10 characters.")]
        [MaxLength(20, ErrorMessage = "This field takes only maximum of 20 characters.")]
        public string TelephoneNumber { get; set; }

        
        public string Country { get; set; }

        public string Province  { get; set; }

        [Display(Name = "Postal Code")]
        [MinLength(6)]
        [MaxLength(6)]
        public string PostalCode { get; set; }
        
        public ICollection<BlogModel> AuthorCollection { get; set; }



    }
}
