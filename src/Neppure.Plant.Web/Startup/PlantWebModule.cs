using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Neppure.Plant.Configuration;
using Neppure.Plant.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Neppure.Plant.Web.Startup
{
    [DependsOn(
        typeof(PlantApplicationModule), 
        typeof(PlantEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class PlantWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PlantWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(PlantConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<PlantNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(PlantApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlantWebModule).GetAssembly());
        }
    }
}