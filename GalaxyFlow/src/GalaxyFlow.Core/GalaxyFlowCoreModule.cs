using Abp.Modules;
using Abp.Reflection.Extensions;
using GalaxyFlow.Localization;

namespace GalaxyFlow
{
    public class GalaxyFlowCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            GalaxyFlowLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GalaxyFlowCoreModule).GetAssembly());
        }
    }
}