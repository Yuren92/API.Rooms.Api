using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Contracts.Repositories
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
        Task<IEnumerable<UserEntity>> GetByEmail(string email);
    }
}
