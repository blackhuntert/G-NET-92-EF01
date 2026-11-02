using Microsoft.EntityFrameworkCore;
using static EF.Program;

namespace EF
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EFCoreDB;Trusted_Connection=True;");
        }
    }
}
