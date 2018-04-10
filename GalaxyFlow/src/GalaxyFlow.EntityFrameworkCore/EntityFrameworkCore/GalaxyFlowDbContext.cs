using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GalaxyFlow.Entities;

namespace GalaxyFlow.EntityFrameworkCore
{
    public class GalaxyFlowDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public GalaxyFlowDbContext(DbContextOptions<GalaxyFlowDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 4);
        }
    }
}
