using Microsoft.EntityFrameworkCore;

namespace Lab04
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Flight> Flights { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=datasource.db");
    }
}