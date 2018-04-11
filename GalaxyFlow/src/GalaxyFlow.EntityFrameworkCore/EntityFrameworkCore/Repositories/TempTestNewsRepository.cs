using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class TempTestNewsRepository : GalaxyFlowRepositoryBase<TempTest_News>, ITempTestNewsRepository
    {
        public TempTestNewsRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
