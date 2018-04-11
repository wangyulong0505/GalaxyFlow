using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class WeiXinMessageRepository : GalaxyFlowRepositoryBase<WeiXinMessage, Guid>, IWeiXinMessageRepository
    {
        public WeiXinMessageRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
