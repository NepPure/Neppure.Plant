using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Neppure.Plant;
using System;

namespace Neppure.DemoCache
{
    [DependsOn(
        typeof(PlantApplicationModule))]
    public class DemoCacheModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DemoCacheModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(DemoCacheModule).GetAssembly()
                , "DemoCache");
        }
    }
}
