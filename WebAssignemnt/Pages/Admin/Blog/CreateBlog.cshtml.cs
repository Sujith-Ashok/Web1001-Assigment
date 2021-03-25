using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAssignemnt.Models;
using WebAssignemnt.Pages.Admin.Author;

namespace WebAssignemnt.Pages.Admin.Blog
{
    public class CreateBlogModel : PageModel
    {
        [FromForm]

        public AuthorModel AuthBlog { get; set; } = new AuthorModel();

        public BlogModel Blog { get; set; } = new BlogModel();

        private List<AuthorModel> Authors { get; set; } = new List<AuthorModel>();

        public IEnumerable<SelectListItem> AuthorList { get; private set; }

        public CreateBlogModel()
        {
            AuthorModel a = new AuthorModel()
            {
                GivenName = "JK ",
                LastName = "Rowling"

            };

            AuthorModel b = new AuthorModel()
            {
                GivenName = "William",
                LastName = "Shakespeare"
            };

            AuthorModel c = new AuthorModel()
            {
                GivenName = "Chetan",
                LastName = "Bhagat"
            };
            AuthorModel d = new AuthorModel()
            {
                GivenName = "Arundathi",
                LastName = "Roy"
            };
            AuthorModel e = new AuthorModel()
            {
                GivenName = "Abdul",
                LastName = "Kalam"
            };



            Authors.Add(a);
            Authors.Add(b);
            Authors.Add(c);
            Authors.Add(d);
            Authors.Add(e);
        }

        public void OnGet()
        {
            AuthorList = Authors.Select(auth =>
            {
                return new SelectListItem(String.Format("{0} {1}", auth.GivenName, auth.LastName), auth.LastName);
            });

        }


        public IActionResult OnPost()
        {
            return RedirectToPage("/DisplayBlog");
        }
        
    }
}
