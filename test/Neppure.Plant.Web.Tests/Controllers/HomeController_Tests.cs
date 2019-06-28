using System.Threading.Tasks;
using Neppure.Plant.Web.Controllers;
using Shouldly;
using Xunit;

namespace Neppure.Plant.Web.Tests.Controllers
{
    public class HomeController_Tests: PlantWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
