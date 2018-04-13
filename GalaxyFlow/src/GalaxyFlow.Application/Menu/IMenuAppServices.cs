using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyFlow.Menu
{
    public interface IMenuAppServices : IApplicationService
    {
        Task<List<Entities.Menu>> GetMenus();

        Task PostMenu(Entities.Menu entity);

        Task PutMenu(Entities.Menu entity);

        Task DeleteMenu(Guid Id);

    }
}
