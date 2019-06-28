using Abp.Runtime.Caching;
using Abp.Timing;
using Abp.UI;
using Neppure.DemoCache.Dtos;
using Neppure.Plant;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Neppure.DemoCache
{
    public class TestAppService : PlantAppServiceBase
    {
        private readonly ICacheManager _cacheManager;

        public TestAppService(ICacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }

        public async Task<DemoItem> GetCacheTest()
        {
            try
            {
                var cache = _cacheManager.GetCache("Demo");
                await cache.SetAsync("key", new DemoItem { Level = 1, Name = "some", Time = Clock.Now });
                var dto = await cache.GetOrDefaultAsync("key");

                if (dto is DemoItem res)
                {
                    return res;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new UserFriendlyException(ex.Message, ex);
            }

        }
    }
}
