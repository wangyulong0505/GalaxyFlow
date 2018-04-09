using Abp.Application.Services;

namespace GalaxyFlow
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class GalaxyFlowAppServiceBase : ApplicationService
    {
        protected GalaxyFlowAppServiceBase()
        {
            LocalizationSourceName = GalaxyFlowConsts.LocalizationSourceName;
        }
    }
}