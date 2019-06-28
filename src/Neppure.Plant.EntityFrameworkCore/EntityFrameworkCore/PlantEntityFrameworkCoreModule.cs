using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Neppure.Plant.EntityFrameworkCore
{
    [DependsOn(
        typeof(PlantCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class PlantEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlantEntityFrameworkCoreModule).GetAssembly());
        }
    }
}