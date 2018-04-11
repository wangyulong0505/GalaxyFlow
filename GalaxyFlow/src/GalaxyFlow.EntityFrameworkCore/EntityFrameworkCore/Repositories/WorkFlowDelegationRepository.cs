using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WorkFlowDelegationRepository : GalaxyFlowRepositoryBase<WorkFlowDelegation, Guid>, IWorkFlowDelegationRepository
    {
        public WorkFlowDelegationRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
