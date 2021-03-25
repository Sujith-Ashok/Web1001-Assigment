using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAssignemnt.Models;

namespace WebAssignemnt.Pages
{
    public class DisplayAuthorModel : PageModel
    {



        [BindProperty(SupportsGet = true)]

        public string GivenName { get; set; }


        public void OnGet()
        {
            
        }

        
    }
}
