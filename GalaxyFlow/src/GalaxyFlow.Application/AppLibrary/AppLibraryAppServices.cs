using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using GalaxyFlow.Entities;
using System.Threading.Tasks;
using GalaxyFlow.IRepositories;

namespace GalaxyFlow.AppLibrary
{
    public class AppLibraryAppServices : ApplicationService, IAppLibraryAppServices
    {
        private readonly IAppLibraryRepository appLibraryRepository;
        public AppLibraryAppServices(IAppLibraryRepository _appLibraryRepository)
        {
            appLibraryRepository = _appLibraryRepository;
        }
        public Task DeleteLibrary(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Entities.AppLibrary>> GetAppLibraries()
        {
            throw new NotImplementedException();
        }

        public Task PostAppLibrary(Entities.AppLibrary entity)
        {
            throw new NotImplementedException();
        }

        public Task PutAppLibrary(Entities.AppLibrary entity)
        {
            throw new NotImplementedException();
        }
    }
}
