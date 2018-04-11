using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class ProgramBuilderExportRepository : GalaxyFlowRepositoryBase<ProgramBuilderExport, Guid>, IProgramBuilderExportRepository
    {
        public ProgramBuilderExportRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
