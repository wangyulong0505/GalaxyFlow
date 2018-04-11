using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WorkFlowArchivesRepository : GalaxyFlowRepositoryBase<WorkFlowArchives, Guid>, IWorkFlowArchivesRepository
    {
        public WorkFlowArchivesRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
