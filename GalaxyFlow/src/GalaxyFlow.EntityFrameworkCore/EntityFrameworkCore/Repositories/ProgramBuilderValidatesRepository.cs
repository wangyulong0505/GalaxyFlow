using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class ProgramBuilderValidatesRepository : GalaxyFlowRepositoryBase<ProgramBuilderValidates, Guid>, IProgramBuilderValidatesRepository
    {
        public ProgramBuilderValidatesRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
