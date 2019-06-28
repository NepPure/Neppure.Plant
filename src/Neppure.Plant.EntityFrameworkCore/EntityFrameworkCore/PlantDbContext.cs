using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Neppure.Plant.EntityFrameworkCore
{
    public class PlantDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public PlantDbContext(DbContextOptions<PlantDbContext> options) 
            : base(options)
        {

        }
    }
}
