using Rooms.Business.Models;
using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Aplication.Contracts.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserEntity>> GetAll();
        Task<UserEntity> GetById(int id);
        Task<UserCompleto> AddUser(UserCompleto user);
        Task DeleteUser(int id);
        Task UpdateUser(UserCompleto user);
        Task<IEnumerable<UserEntity>> GetByEmail(string email);
    }
}
