using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WorkFlowFormRepository : GalaxyFlowRepositoryBase<WorkFlowForm, Guid>, IWorkFlowFormRepository
    {
        public WorkFlowFormRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
