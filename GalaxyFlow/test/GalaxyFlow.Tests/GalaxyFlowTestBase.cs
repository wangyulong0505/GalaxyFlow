using System;
using System.Threading.Tasks;
using Abp.TestBase;
using GalaxyFlow.EntityFrameworkCore;
using GalaxyFlow.Tests.TestDatas;

namespace GalaxyFlow.Tests
{
    public class GalaxyFlowTestBase : AbpIntegratedTestBase<GalaxyFlowTestModule>
    {
        public GalaxyFlowTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<GalaxyFlowDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<GalaxyFlowDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<GalaxyFlowDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<GalaxyFlowDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<GalaxyFlowDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<GalaxyFlowDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<GalaxyFlowDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<GalaxyFlowDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
