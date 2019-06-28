using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Neppure.Plant.EntityFrameworkCore;
using Neppure.Plant.Tests.TestDatas;

namespace Neppure.Plant.Tests
{
    public class PlantTestBase : AbpIntegratedTestBase<PlantTestModule>
    {
        public PlantTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<PlantDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<PlantDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<PlantDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<PlantDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<PlantDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<PlantDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<PlantDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<PlantDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
