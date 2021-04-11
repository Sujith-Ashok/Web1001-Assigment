using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAssignemnt.Context;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages.CRUD.BlogPost
{
    public class DetailsModel : PageModel
    {
        private readonly WebAssignemnt.Context.DataContext _context;

        public DetailsModel(WebAssignemnt.Context.DataContext context)
        {
            _context = context;
        }

        public BlogModel BlogModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlogModel = await _context.Blogs.FirstOrDefaultAsync(m => m.BlogID == id);

            if (BlogModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
