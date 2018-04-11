using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class DocumentDirectoryRepository : GalaxyFlowRepositoryBase<DocumentDirectory, Guid>, IDocumentDirectoryRepository
    {
        public DocumentDirectoryRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
