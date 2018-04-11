using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class DocumentsReadUsersRepository : GalaxyFlowRepositoryBase<DocumentsReadUsers, Guid>, IDocumentsReadUsersRepository
    {
        public DocumentsReadUsersRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
