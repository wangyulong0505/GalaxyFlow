using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class TempTestPurchaseListRepository : GalaxyFlowRepositoryBase<TempTest_PurchaseList, Guid>, ITempTestPurchaseListRepository
    {
        public TempTestPurchaseListRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
