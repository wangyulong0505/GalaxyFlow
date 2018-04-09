using System.Threading.Tasks;
using GalaxyFlow.Web.Controllers;
using Shouldly;
using Xunit;

namespace GalaxyFlow.Web.Tests.Controllers
{
    public class HomeController_Tests: GalaxyFlowWebTestBase
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
