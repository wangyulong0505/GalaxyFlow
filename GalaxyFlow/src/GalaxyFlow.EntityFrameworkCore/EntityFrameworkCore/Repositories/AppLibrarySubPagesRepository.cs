using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class AppLibrarySubPagesRepository : GalaxyFlowRepositoryBase<AppLibrarySubPages, Guid>, IAppLibrarySubPagesRepository
    {
        public AppLibrarySubPagesRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
