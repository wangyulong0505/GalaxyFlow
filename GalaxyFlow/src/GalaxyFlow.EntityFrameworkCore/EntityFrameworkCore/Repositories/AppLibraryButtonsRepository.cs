using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class AppLibraryButtonsRepository : GalaxyFlowRepositoryBase<AppLibraryButtons, Guid>, IAppLibraryButtonsRepository
    {
        public AppLibraryButtonsRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
