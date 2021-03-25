using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages.Admin.Author
{
    public class CreateAuthorModel : PageModel
    {

        [FromForm]

        public AuthorModel Author { get; set; } = new AuthorModel();

        

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
           return RedirectToPage("/DisplayAuthor", new { GivenName = Author.GivenName });
        }
    }
}
