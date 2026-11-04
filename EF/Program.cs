#pragma warning disable 

using Microsoft.EntityFrameworkCore;

namespace EF
{
    internal class Program
    {

        static async Task Main(string[] args)
        {
            using BookStoreDbContext context = new BookStoreDbContext();
            await context.Database.MigrateAsync();
            //try
            //{
            //    using var context = new AppDbContext();
            //    bool created = context.Database.EnsureCreated();

            //    if (created)
            //    {
            //        Console.WriteLine("✅ Database 'BookstoreDb' created successfully!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("ℹ️ Database already exists.");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("❌ Error connecting to database:");
            //    Console.WriteLine(ex.Message);
            //}


        }
    }
}
