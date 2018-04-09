using GalaxyFlow.Configuration;
using GalaxyFlow.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace GalaxyFlow.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class GalaxyFlowDbContextFactory : IDesignTimeDbContextFactory<GalaxyFlowDbContext>
    {
        public GalaxyFlowDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<GalaxyFlowDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(GalaxyFlowConsts.ConnectionStringName)
            );

            return new GalaxyFlowDbContext(builder.Options);
        }
    }
}