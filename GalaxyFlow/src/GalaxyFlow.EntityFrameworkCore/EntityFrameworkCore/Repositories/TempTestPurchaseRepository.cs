using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class TempTestPurchaseRepository : GalaxyFlowRepositoryBase<TempTest_Purchase, Guid>, ITempTestPurchaseRepository
    {
        public TempTestPurchaseRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
