using Microsoft.EntityFrameworkCore;
using Rooms.DataAccess.Contracts;
using Rooms.DataAccess.Contracts.Entities;
using Rooms.DataAccess.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        private readonly IRoomsDBContext _roomsDBContext;

        public UserRepository(RoomsDBContext context) : base(context)
        {
            _roomsDBContext = context;
        }

        public async Task<IEnumerable<UserEntity>> GetByEmail(string email)
        {
            return await  _roomsDBContext.Users.Where(x => x.email == email).ToListAsync(); ;
        }
    }
}
