using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Neppure.Plant
{
    [DependsOn(
        typeof(PlantCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PlantApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlantApplicationModule).GetAssembly());
        }
    }
}