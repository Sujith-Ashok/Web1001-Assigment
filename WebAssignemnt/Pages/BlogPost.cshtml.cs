using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebAssignemnt.Context;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages
{
    public class BlogPostModel : PageModel
    {
        private readonly DataContext _context;

        public BlogPostModel(DataContext context)
        {
            _context = context;
        }

        //[BindProperty]
        //public BlogModel BlogPost { get; set; }

        public Models.BlogModel DisplayPost;

        public void OnGet(int? id)
        {
            if (id != null)
            {
                DisplayPost = _context.Blogs.Where(m => m.BlogID == id).FirstOrDefault();
            }

        }


       
    }
}
