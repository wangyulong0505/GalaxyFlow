using Abp.AspNetCore.Mvc.Views;

namespace GalaxyFlow.Web.Views
{
    public abstract class GalaxyFlowRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected GalaxyFlowRazorPage()
        {
            LocalizationSourceName = GalaxyFlowConsts.LocalizationSourceName;
        }
    }
}
