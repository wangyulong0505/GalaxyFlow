using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class ProgramBuilderButtonsRepository : GalaxyFlowRepositoryBase<ProgramBuilderButtons, Guid>, IProgramBuilderButtonsRepository
    {
        public ProgramBuilderButtonsRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
