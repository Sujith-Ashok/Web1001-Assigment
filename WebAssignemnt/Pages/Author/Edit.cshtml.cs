using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAssignemnt.Context;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages.Author
{
    public class EditModel : PageModel
    {
        private readonly WebAssignemnt.Context.DataContext _context;

        public EditModel(WebAssignemnt.Context.DataContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AuthorModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorModelExists(AuthorModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AuthorModelExists(int id)
        {
            return _context.Authors.Any(e => e.ID == id);
        }
    }
}
