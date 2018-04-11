using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class LogRepository : GalaxyFlowRepositoryBase<Log, Guid>, ILogRepository
    {
        public LogRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
