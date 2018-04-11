using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WorkFlowTaskRepository : GalaxyFlowRepositoryBase<WorkFlowTask, Guid>, IWorkFlowTaskRepository
    {
        public WorkFlowTaskRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
