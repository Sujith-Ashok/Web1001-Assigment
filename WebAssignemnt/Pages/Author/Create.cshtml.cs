using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAssignemnt.Context;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages.Author
{
    public class CreateModel : PageModel
    {
        private readonly WebAssignemnt.Context.DataContext _context;

        public CreateModel(WebAssignemnt.Context.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AuthorModel AuthorModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Authors.Add(AuthorModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
