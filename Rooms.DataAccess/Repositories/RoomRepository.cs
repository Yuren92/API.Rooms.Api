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
    public class RoomRepository : GenericRepository<RoomEntity>, IRoomRepository
    {
        private readonly IRoomsDBContext _roomsDBContext;

        public RoomRepository(RoomsDBContext context) : base(context)
        {
            _roomsDBContext = context;
        }

        public async Task<IEnumerable<RoomEntity>> GetRoomsFromUser(int id)
        {
            return await _context.Rooms.Where(x => x.userId == id).ToListAsync();
        }

        public async Task<IEnumerable<RoomEntity>> GetRoomsFromLocality(string locality)
        {
            return await _context.Rooms.Where(x => x.locality == locality).ToListAsync();
        }
    }
}
