using Microsoft.EntityFrameworkCore;

namespace Neppure.Plant.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<PlantDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for PlantDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
