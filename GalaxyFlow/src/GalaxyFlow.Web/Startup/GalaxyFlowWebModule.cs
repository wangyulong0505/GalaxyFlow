using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GalaxyFlow.Configuration;
using GalaxyFlow.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace GalaxyFlow.Web.Startup
{
    [DependsOn(
        typeof(GalaxyFlowApplicationModule), 
        typeof(GalaxyFlowEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class GalaxyFlowWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public GalaxyFlowWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(GalaxyFlowConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<GalaxyFlowNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(GalaxyFlowApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GalaxyFlowWebModule).GetAssembly());
        }
    }
}