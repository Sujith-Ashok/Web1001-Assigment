using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAssignemnt.Context;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages.Author
{
    public class DeleteModel : PageModel
    {
        private readonly WebAssignemnt.Context.DataContext _context;

        public DeleteModel(WebAssignemnt.Context.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AuthorModel AuthorModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuthorModel = await _context.Authors.FirstOrDefaultAsync(m => m.ID == id);

            if (AuthorModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AuthorModel = await _context.Authors.FindAsync(id);

            if (AuthorModel != null)
            {
                _context.Authors.Remove(AuthorModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
