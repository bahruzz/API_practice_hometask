using API_Practice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace API_Practice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
          new Category
          {
              Id = 1,
              CreatedDate = DateTime.Now,
              Name = "Ui UX",

          },
          new Category
          {
              Id = 2,
              Name = "Backend",
              CreatedDate = DateTime.Now,
          },
          new Category
          {
              Id = 3,
              Name = "Frontend",
              CreatedDate = DateTime.Now,
          }
      );



        }
    }
}
