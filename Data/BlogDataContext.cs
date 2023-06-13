using BlogEF.Data.Mappings;
using BlogEF.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogEF.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NTBGFINF13\\SQLEXPRESS;Database=blog;Trusted_Connection=True;TrustServerCertificate=true;");
            //optionsBuilder.LogTo(Console.WriteLine); //! Traz o log de todo o processo

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }


    }
}