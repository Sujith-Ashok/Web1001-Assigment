using System;
using Microsoft.EntityFrameworkCore;
using WebAssignemnt.Models;

namespace WebAssignemnt.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            
        }

        public DbSet<AuthorModel> Authors { get; set; }

        public DbSet<BlogModel> Blogs { get; set; }
    }
}
