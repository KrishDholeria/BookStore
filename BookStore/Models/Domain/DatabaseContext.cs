using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models.Domain
{
    public class DatabaseContext: IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base (options)
        {

        }

        public DbSet<Genre> Genre { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
