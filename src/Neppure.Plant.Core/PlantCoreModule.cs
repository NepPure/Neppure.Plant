using Abp.Modules;
using Abp.Reflection.Extensions;
using Neppure.Plant.Localization;

namespace Neppure.Plant
{
    public class PlantCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            PlantLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlantCoreModule).GetAssembly());
        }
    }
}