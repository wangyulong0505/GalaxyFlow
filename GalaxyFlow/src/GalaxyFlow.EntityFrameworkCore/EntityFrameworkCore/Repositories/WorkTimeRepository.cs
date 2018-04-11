using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WorkTimeRepository : GalaxyFlowRepositoryBase<WorkTime, Guid>, IWorkTimeRepository
    {
        public WorkTimeRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
