using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using GalaxyFlow.Entities;
using System.Threading.Tasks;
using GalaxyFlow.IRepositories;

namespace GalaxyFlow.Menu
{
    public class MenuAppServices : ApplicationService, IMenuAppServices
    {
        private readonly IMenuRepository menuRepository;
        public MenuAppServices(IMenuRepository _menuRepository)
        {
            menuRepository = _menuRepository;
        }

        public async Task DeleteMenu(Guid Id)
        {
            await menuRepository.DeleteAsync(Id);
        }

        public async Task<List<Entities.Menu>> GetMenus()
        {
            return await menuRepository.GetAllListAsync();
        }

        public async Task PostMenu(Entities.Menu entity)
        {
            await menuRepository.InsertAsync(entity);
        }

        public async Task PutMenu(Entities.Menu entity)
        {
            await menuRepository.UpdateAsync(entity);
        }
    }
}
