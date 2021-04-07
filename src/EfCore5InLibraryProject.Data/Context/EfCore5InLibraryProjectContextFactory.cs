using EfCore5InLibraryProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EfCore5InLibraryProject.Data
{
    public class EfCore5InLibraryProjectContextFactory : IDesignTimeDbContextFactory<EfCore5InLibraryProjectDbContext>
    {
        public EfCore5InLibraryProjectContextFactory() { }

        private IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        public EfCore5InLibraryProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EfCore5InLibraryProjectDbContext>();

            builder.UseNpgsql(Configuration.GetConnectionString("postgres"));

            return new EfCore5InLibraryProjectDbContext(builder.Options);
        }
    }
}
