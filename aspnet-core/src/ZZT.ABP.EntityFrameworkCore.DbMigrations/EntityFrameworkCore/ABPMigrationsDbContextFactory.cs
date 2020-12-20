using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ZZT.ABP.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ABPMigrationsDbContextFactory : IDesignTimeDbContextFactory<ABPMigrationsDbContext>
    {
        public ABPMigrationsDbContext CreateDbContext(string[] args)
        {
            ABPEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ABPMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ABPMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ZZT.ABP.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
