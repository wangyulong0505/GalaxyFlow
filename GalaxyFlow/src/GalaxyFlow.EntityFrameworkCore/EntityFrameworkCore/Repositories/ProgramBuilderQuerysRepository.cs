using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class ProgramBuilderQuerysRepository : GalaxyFlowRepositoryBase<ProgramBuilderQuerys, Guid>, IProgramBuilderQuerysRepository
    {
        public ProgramBuilderQuerysRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
