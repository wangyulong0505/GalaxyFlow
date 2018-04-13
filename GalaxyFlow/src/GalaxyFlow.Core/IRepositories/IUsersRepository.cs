using Abp.Domain.Repositories;
using GalaxyFlow.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyFlow.IRepositories
{
    public interface IUsersRepository : IRepository<Users, Guid>
    {
        int GetLoginStatus(string account, string pwd);

        Task<Entities.Users> GetUser(string strUserName);
    }
}
