using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class AppLibraryRepository : GalaxyFlowRepositoryBase<AppLibrary, Guid>, IAppLibraryRepository
    {
        public AppLibraryRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
