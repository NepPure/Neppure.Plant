using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Neppure.Plant.Web.Startup;
namespace Neppure.Plant.Web.Tests
{
    [DependsOn(
        typeof(PlantWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class PlantWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PlantWebTestModule).GetAssembly());
        }
    }
}