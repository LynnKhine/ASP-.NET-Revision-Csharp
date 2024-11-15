using APItest.Entities;
using Microsoft.EntityFrameworkCore;

namespace APItest.Data;
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your tables here as DbSet<T>
        public DbSet<MovieEntity> MovieDbSet { get; set; }

        public DbSet<StudentEntity> StudentDbSet { get; set; }

        // You can override OnModelCreating if you need additional configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration here if needed
        }
}
