using Abp.Web.Models;
using GalaxyFlow.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using GalaxyFlow.Users;
using System.Security.Claims;
using System.Collections.Generic;
using System;
using GalaxyFlow.Web.Models.Account;
using Newtonsoft.Json;
using GalaxyFlow.Users.Dto;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace GalaxyFlow.Web.Controllers
{
    public class AccountController : GalaxyFlowControllerBase
    {
        private readonly IUsersAppServices usersAppServices;
        public AccountController(IUsersAppServices _usersAppServices)
        {
            usersAppServices = _usersAppServices;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public virtual async Task<JsonResult> Login(LoginViewModel model)
        {
            int loginStatus = -1;
            loginStatus = usersAppServices.GetLoginStatus(model.UserName, model.Password);
            Entities.Users entity = await usersAppServices.GetUser(model.UserName);
            if (loginStatus == 0)
            {
                List<Claim> claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, model.UserName),
                    new Claim(ClaimTypes.Surname, entity.Name),
                    new Claim(ClaimTypes.Sid, entity.Id.ToString())
                };
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = model.RememberMe });
            }
            return Json(new AjaxResponse { Result = loginStatus });
        }


        #region 注销

        [AllowAnonymous]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        #endregion

        #region 其他

        /// <summary>
        /// 验证用户名是否唯一
        /// </summary>
        public virtual JsonResult CheckUnique(string name)
        {
            bool result = true;
            List<UserDto> Users = usersAppServices.GetDtoUsers();
            foreach (UserDto user in Users)
            {
                if (user.UserName.Equals(name))
                {
                    result = false;
                    break;
                }
            }
            Dictionary<string, bool> dic = new Dictionary<string, bool>
            {
                { "valid", result }
            };
            //转化为Json输出
            //返回数据
            return Json(new AjaxResponse { Result = JsonConvert.SerializeObject(dic) });
        }

        public async Task<JsonResult> GetUserId()
        {
            try
            {
                string strUserName = User.Identity.Name;
                Entities.Users user = await usersAppServices.GetUser(strUserName);
                return Json(new AjaxResponse { Success = true, Result = user.Id });
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return Json(new AjaxResponse { Success = false, Result = ex.Message });
            }
        }

        #endregion




    }
}