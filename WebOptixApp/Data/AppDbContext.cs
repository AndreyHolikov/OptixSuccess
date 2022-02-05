
using Microsoft.EntityFrameworkCore;

namespace WebOptixApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category>? Categories { get; set; }

        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=pc-631\sqlexpress;Initial Catalog=WebOptixApp;Integrated Security=True;Pooling=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
