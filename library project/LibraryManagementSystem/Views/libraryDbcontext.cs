using Microsoft.EntityFrameworkCore; // Required for DbContext
using LibraryManagementSystem.Models; // Ensure User and Book exist

namespace LibraryManagementSystem.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
