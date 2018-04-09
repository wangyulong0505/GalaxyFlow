using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore
{
    public class GalaxyFlowDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public GalaxyFlowDbContext(DbContextOptions<GalaxyFlowDbContext> options) 
            : base(options)
        {

        }
    }
}
