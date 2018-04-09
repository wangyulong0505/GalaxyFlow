using Abp.AspNetCore.Mvc.Controllers;

namespace GalaxyFlow.Web.Controllers
{
    public abstract class GalaxyFlowControllerBase: AbpController
    {
        protected GalaxyFlowControllerBase()
        {
            LocalizationSourceName = GalaxyFlowConsts.LocalizationSourceName;
        }
    }
}