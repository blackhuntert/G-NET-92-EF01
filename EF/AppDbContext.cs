using Microsoft.EntityFrameworkCore;
using static EF.Program;

namespace EF
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() :base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
                optionsBuilder.UseSqlServer("Server= .;Database=BookstoreDb;Trusted_Connection=True;TrustServerCertificate=True;");
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
