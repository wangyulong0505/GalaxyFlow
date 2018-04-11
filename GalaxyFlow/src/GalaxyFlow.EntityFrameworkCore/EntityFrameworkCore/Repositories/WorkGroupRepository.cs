using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WorkGroupRepository : GalaxyFlowRepositoryBase<WorkGroup, Guid>, IWorkGroupRepository
    {
        public WorkGroupRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
