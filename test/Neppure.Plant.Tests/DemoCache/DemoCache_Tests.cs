using Neppure.DemoCache;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Neppure.Plant.Tests.DemoCache
{
    public class DemoCache_Tests : PlantTestBase
    {
        private readonly TestAppService _testAppService;

        public DemoCache_Tests()
        {
            _testAppService = Resolve<TestAppService>();
        }

        [Fact]
        public async Task InMemoryTest()
        {
            await _testAppService.GetCacheTest();
        }
    }
}
