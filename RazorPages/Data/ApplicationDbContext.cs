using Microsoft.EntityFrameworkCore;
using RazorPages.Models;



namespace RazorPages.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Categories>().HasData(
                new Categories { Id = 1, Name = "Action", DisplayOrder = 2 },
                new Categories { Id = 2, Name = "Drama", DisplayOrder = 1 },
                new Categories { Id = 3, Name = "Horror", DisplayOrder = 3 }
            );
        }
    }
}
