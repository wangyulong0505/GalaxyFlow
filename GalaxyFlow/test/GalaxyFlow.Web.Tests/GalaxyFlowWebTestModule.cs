using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GalaxyFlow.Web.Startup;
namespace GalaxyFlow.Web.Tests
{
    [DependsOn(
        typeof(GalaxyFlowWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class GalaxyFlowWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GalaxyFlowWebTestModule).GetAssembly());
        }
    }
}