using EfCore5InLibraryProject.Data.Mapping;
using EfCore5InLibraryProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using TestEfCore5.Data.Mapping;

namespace EfCore5InLibraryProject.Data.Context
{
    public class EfCore5InLibraryProjectDbContext : DbContext
    {
        public EfCore5InLibraryProjectDbContext(DbContextOptions<EfCore5InLibraryProjectDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Addd the Postgres Extension for UUID generation
            // More info: https://www.npgsql.org/efcore/modeling/generated-properties.html#guiduuid-generation
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.ApplyConfiguration(new CompanyMapping());
            modelBuilder.ApplyConfiguration(new CustomerMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
