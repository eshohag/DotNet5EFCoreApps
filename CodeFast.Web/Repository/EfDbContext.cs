using CodeFast.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFast.Web.Repository
{
    public class EfDbContext : DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {
            this.Database.Migrate();
        }
        public DbSet<Student> Students { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Students");
        }
    }
}
