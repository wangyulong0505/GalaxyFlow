using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Authorization;

namespace GalaxyFlow.Web.Controllers
{
    [Authorize]
    public abstract class GalaxyFlowControllerBase: AbpController
    {
        protected GalaxyFlowControllerBase()
        {
            LocalizationSourceName = GalaxyFlowConsts.LocalizationSourceName;
        }
    }
}