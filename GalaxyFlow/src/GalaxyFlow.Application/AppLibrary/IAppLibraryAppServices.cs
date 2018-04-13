using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyFlow.AppLibrary
{
    public interface IAppLibraryAppServices : IApplicationService
    {
        Task<List<Entities.AppLibrary>> GetAppLibraries();

        Task PostAppLibrary(Entities.AppLibrary entity);

        Task PutAppLibrary(Entities.AppLibrary entity);

        Task DeleteLibrary(Guid Id);
    }
}
