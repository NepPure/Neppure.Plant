using Neppure.Plant.Configuration;
using Neppure.Plant.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Neppure.Plant.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class PlantDbContextFactory : IDesignTimeDbContextFactory<PlantDbContext>
    {
        public PlantDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PlantDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(PlantConsts.ConnectionStringName)
            );

            return new PlantDbContext(builder.Options);
        }
    }
}