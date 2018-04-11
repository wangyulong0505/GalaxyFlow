using Abp.Domain.Repositories;
using GalaxyFlow.Entities;
using System;

namespace GalaxyFlow.IRepositories
{
    public interface IDocumentsRepository : IRepository<Documents, Guid>
    {
    }
}
