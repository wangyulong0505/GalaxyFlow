using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class DictionaryRepository : GalaxyFlowRepositoryBase<Dictionary, Guid>, IDictionaryRepository
    {
        public DictionaryRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
