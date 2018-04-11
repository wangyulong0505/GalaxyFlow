using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WorkFlowButtonsRepository : GalaxyFlowRepositoryBase<WorkFlowButtons, Guid>, IWorkFlowButtonsRepository
    {
        public WorkFlowButtonsRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
