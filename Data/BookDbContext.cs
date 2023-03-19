using FreshBooks.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreshBooks.Data
{
    public class BookDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) 
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            /*            modelBuilder.Entity<Author_Books>().HasKey(ab => new
                        {
                            ab.AuthorId,
                            ab.BookId
                        });
                        modelBuilder.Entity<Author_Books>().HasOne(b => b.Book).WithMany(ab => ab.Author_Books).HasForeignKey(b => b.BookId);
                        modelBuilder.Entity<Author_Books>().HasOne(b => b.Author).WithMany(ab => ab.Author_Books).HasForeignKey(b => b.AuthorId);
                        base.OnModelCreating(modelBuilder);*/
        }

/*        public DbSet<Author> Author { get; set; }
*/        public DbSet<Book> Book { get; set; }
/*        public DbSet<Author_Books> Author_Books { get; set; }
*/    }
}
