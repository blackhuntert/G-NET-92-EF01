#pragma warning disable 

using Microsoft.EntityFrameworkCore;

namespace EF
{
    internal class Program
    {
        public class Author
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Biography { get; set; }
            public DateTime DateOfBirth { get; set; }

            public ICollection<Book> Books { get; set; } = new HashSet<Book>();
        
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsActive { get; set; }

            public ICollection<Book> Books { get; set; } = new HashSet<Book>();
        }

        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
            public int Pages { get; set; }
            public int PublishedYear { get; set; }
            public bool InStock { get; set; }

            public int CategoryId { get; set; }
            public Category Category { get; set; }

            public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
        }
        static void Main(string[] args)
        {
            try
            {
                using var context = new AppDbContext();
                bool created = context.Database.EnsureCreated();

                if (created)
                {
                    Console.WriteLine("✅ Database 'BookstoreDb' created successfully!");
                }
                else
                {
                    Console.WriteLine("ℹ️ Database already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error connecting to database:");
                Console.WriteLine(ex.Message);
            }

            AppDbContext _context = new AppDbContext();
        }
    }
}
