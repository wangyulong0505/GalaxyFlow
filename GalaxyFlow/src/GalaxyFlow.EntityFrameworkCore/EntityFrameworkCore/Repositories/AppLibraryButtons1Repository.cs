using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class AppLibraryButtons1Repository : GalaxyFlowRepositoryBase<AppLibraryButtons1, Guid>, IAppLibraryButtons1Repository
    {
        public AppLibraryButtons1Repository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
