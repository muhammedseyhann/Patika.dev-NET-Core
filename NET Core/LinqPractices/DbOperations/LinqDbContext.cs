using Microsoft.EntityFrameworkCore;

namespace linq_practices.DbOperations
{
    public class LİnqDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "LinqDatabase");
        }

    }
}