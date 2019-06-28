using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Neppure.Plant.Configuration;
using Neppure.Plant.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Runtime.Caching.Redis;

namespace Neppure.Plant.Web.Startup
{
    [DependsOn(
        typeof(PlantApplicationModule),
        typeof(PlantEntityFrameworkCoreModule),
        typeof(AbpRedisCacheModule),
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

            Configuration.Caching.UseRedis(options =>
            {
                options.ConnectionString = "127.0.0.1";
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlantWebModule).GetAssembly());
        }
    }
}