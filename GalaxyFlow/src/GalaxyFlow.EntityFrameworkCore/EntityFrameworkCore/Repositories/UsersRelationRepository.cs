using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class UsersRelationRepository : GalaxyFlowRepositoryBase<UsersRelation, Guid>, IUsersRelationRepository
    {
        public UsersRelationRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
