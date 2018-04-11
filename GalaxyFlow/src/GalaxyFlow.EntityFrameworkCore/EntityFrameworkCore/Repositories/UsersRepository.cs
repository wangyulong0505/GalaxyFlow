using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class UsersRepository : GalaxyFlowRepositoryBase<Users, Guid>, IUsersRepository
    {
        public UsersRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
