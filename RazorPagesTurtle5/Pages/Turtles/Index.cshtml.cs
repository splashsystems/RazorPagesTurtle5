using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle5.Data;
using RazorPagesTurtle5.Models;

namespace RazorPagesTurtle5.Pages.Turtles
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesTurtle5.Data.RazorPagesTurtle5Context _context;

        public IndexModel(RazorPagesTurtle5.Data.RazorPagesTurtle5Context context)
        {
            _context = context;
        }

        public IList<Turtle> Turtle { get;set; }

        public async Task OnGetAsync()
        {
            Turtle = await _context.Turtle.ToListAsync();
        }
    }
}
