using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace GalaxyFlow.EntityFrameworkCore
{
    [DependsOn(
        typeof(GalaxyFlowCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class GalaxyFlowEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GalaxyFlowEntityFrameworkCoreModule).GetAssembly());
        }
    }
}