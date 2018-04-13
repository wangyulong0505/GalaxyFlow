using GalaxyFlow.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GalaxyFlow.Web.Views.Shared.Components.Menus
{
    [ViewComponent(Name = "Menu")]
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuAppServices menuAppServices;
        public MenuViewComponent(IMenuAppServices _menuAppServices)
        {
            //
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //根据用户的权限获取对应的菜单，为了演示效果先默认获取所有
            List<Entities.Menu> menus = await menuAppServices.GetMenus();
            return View(menus);
        }
    }
}
