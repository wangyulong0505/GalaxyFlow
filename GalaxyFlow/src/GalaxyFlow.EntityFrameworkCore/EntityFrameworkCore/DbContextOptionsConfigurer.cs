using Microsoft.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<GalaxyFlowDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for GalaxyFlowDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
