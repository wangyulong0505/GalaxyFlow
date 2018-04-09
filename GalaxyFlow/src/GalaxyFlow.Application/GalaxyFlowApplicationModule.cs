using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace GalaxyFlow
{
    [DependsOn(
        typeof(GalaxyFlowCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GalaxyFlowApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GalaxyFlowApplicationModule).GetAssembly());
        }
    }
}