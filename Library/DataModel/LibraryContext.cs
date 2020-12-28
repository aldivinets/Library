using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.DataModel
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }
    }
}
