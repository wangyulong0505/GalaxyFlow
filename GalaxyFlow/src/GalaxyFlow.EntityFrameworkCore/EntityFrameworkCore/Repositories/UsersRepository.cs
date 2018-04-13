using Abp.EntityFrameworkCore;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxyFlow.EntityFrameworkCore.Repositories
{
    public class UsersRepository : GalaxyFlowRepositoryBase<Users, Guid>, IUsersRepository
    {
        public UsersRepository(IDbContextProvider<GalaxyFlowDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public int GetLoginStatus(string account, string pwd)
        {
            //按照用户名的验证规则
            Users entity = GetAll().SingleOrDefault(q => q.Account == account);
            if (entity == null)
            {
                //用户不存在
                return 1;
            }
            //密码Md5加密
            string encryptPassword = Core.Tools.Encrypt.Md5Hash(Core.Tools.Encrypt.Md5Hash(account.ToLower() + pwd)).ToUpper();
            if (encryptPassword == entity.Password)
            {
                //验证通过
                return 0;
            }
            return 2;
        }

        public async Task<Entities.Users> GetUser(string strUserName)
        {
            return await Task.Run(()=>GetAll().SingleOrDefault(q => q.Account == strUserName && q.Status == 0));
        }
    }
}
