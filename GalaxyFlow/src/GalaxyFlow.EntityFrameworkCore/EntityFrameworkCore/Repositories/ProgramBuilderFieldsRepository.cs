using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using Abp.EntityFrameworkCore;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class ProgramBuilderFieldsRepository : GalaxyFlowRepositoryBase<ProgramBuilderFields, Guid>, IProgramBuilderFieldsRepository
    {
        public ProgramBuilderFieldsRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
