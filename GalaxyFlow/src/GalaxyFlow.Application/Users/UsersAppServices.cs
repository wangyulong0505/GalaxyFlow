using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using GalaxyFlow.Entities;
using GalaxyFlow.IRepositories;
using GalaxyFlow.Users.Dto;
using System.Linq;
using AutoMapper;

namespace GalaxyFlow.Users
{
    public class UsersAppServices : ApplicationService, IUsersAppServices
    {
        private readonly IUsersRepository usersRepository;
        public UsersAppServices(IUsersRepository _usersRepository)
        {
            usersRepository = _usersRepository;
        }

        public Task DeleteUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<UserDto> GetDtoUsers()
        {
            List<Entities.Users> list = usersRepository.GetAll().Where(q=>q.Status == 0).ToList();
            return Mapper.Map<List<Entities.Users>, List<UserDto>>(list);
        }

        public int GetLoginStatus(string account, string pwd)
        {
            return usersRepository.GetLoginStatus(account, pwd);
        }

        /// <summary>
        /// 根据用户名获取用户Id
        /// </summary>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public async Task<Entities.Users> GetUser(string strUserName)
        {
            return await usersRepository.GetUser(strUserName);
        }

        public Task<List<Entities.Users>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task PostUser(Entities.Users entity)
        {
            throw new NotImplementedException();
        }

        public Task PutUser(Entities.Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
