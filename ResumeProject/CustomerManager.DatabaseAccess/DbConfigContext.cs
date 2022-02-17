using CustomerManager.Model;
using Microsoft.EntityFrameworkCore;

namespace CustomerManager.DatabaseAccess
{
    public class DbConfigContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerType> CustomerTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAW172\SQL2019; Database=CustomerManager; Trusted_Connection=True");
        }
    }
}