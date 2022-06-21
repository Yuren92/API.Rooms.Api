using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Contracts.Repositories
{
    public interface IRoomRepository : IGenericRepository<RoomEntity>
    {
        Task<IEnumerable<RoomEntity>> GetRoomsFromUser(int id);
        Task<IEnumerable<RoomEntity>> GetRoomsFromLocality(string locality);
    }
}
