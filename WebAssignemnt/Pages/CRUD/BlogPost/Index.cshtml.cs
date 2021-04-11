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
    public class IndexModel : PageModel
    {
        private readonly WebAssignemnt.Context.DataContext _context;

        public IndexModel(WebAssignemnt.Context.DataContext context)
        {
            _context = context;
        }

        public IList<BlogModel> BlogModel { get;set; }

        public async Task OnGetAsync()
        {
            BlogModel = await _context.Blogs.ToListAsync();
        }
    }
}
