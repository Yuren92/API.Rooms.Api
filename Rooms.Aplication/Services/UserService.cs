using Rooms.Aplication.Contracts.Services;
using Rooms.Business.Models;
using Rooms.DataAccess.Contracts.Entities;
using Rooms.DataAccess.Contracts.Repositories;
using Rooms.DataAccess.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Aplication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _userRepository.GetAll();

        }

        public async Task<UserEntity> GetById(int id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<UserCompleto> AddUser(UserCompleto user)
        {
            await _userRepository.Add(UserMapper.Map(user));
            return user;
        }
        public Task DeleteUser(int id)
        {
            var user = _userRepository.GetById(id);
            _userRepository.Remove(user.Result);
            return Task.CompletedTask;
        }

        public async Task UpdateUser(UserCompleto user)
        {
            await _userRepository.Update(UserMapper.Map(user));
        }

        public async Task<IEnumerable<UserEntity>> GetByEmail(string email)
        {
             return await _userRepository.GetByEmail(email);
        }
    }
}
