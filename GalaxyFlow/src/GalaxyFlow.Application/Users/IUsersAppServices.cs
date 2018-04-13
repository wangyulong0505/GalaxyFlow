using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyFlow.Users
{
    public interface IUsersAppServices : IApplicationService
    {
        Task<List<Entities.Users>> GetUsers();

        Task PostUser(Entities.Users entity);

        Task PutUser(Entities.Users entity);

        Task DeleteUser(Guid Id);

        int GetLoginStatus(string account, string pwd);

        Task<Entities.Users> GetUser(string strUserName);

        List<Dto.UserDto> GetDtoUsers();
    }
}
