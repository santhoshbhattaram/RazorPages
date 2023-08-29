using Microsoft.EntityFrameworkCore;
using RazorPages.Models;



namespace RazorPages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 2 },
                new Category { Id = 2, Name = "Drama", DisplayOrder = 1 },
                new Category { Id = 3, Name = "Horror", DisplayOrder = 3 }
            );
        }
    }
}
