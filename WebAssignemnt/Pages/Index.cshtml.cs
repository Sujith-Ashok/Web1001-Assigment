using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebAssignemnt.Context;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataContext _context;

        public IndexModel(ILogger<IndexModel> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }


        public ICollection<Models.BlogModel> homePagePost;
        public ICollection<Models.BlogModel> Reverse;

        public void OnGet()
        {
            homePagePost = _context.Blogs.Take(5).ToList();
            
        }
    }
}
