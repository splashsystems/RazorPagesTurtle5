using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesTurtle5.Models;

namespace RazorPagesTurtle5.Data
{
    public class RazorPagesTurtle5Context : DbContext
    {
        public RazorPagesTurtle5Context (DbContextOptions<RazorPagesTurtle5Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTurtle5.Models.Turtle> Turtle { get; set; }
    }
}
