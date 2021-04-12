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
    public class DetailsModel : PageModel
    {
        private readonly WebAssignemnt.Context.DataContext _context;

        public DetailsModel(WebAssignemnt.Context.DataContext context)
        {
            _context = context;
        }

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
    }
}
