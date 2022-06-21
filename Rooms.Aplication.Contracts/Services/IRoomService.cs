using Rooms.Business.Models;
using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Aplication.Contracts.Services
{
    public interface IRoomService
    {
        Task<IEnumerable<RoomEntity>> GetAll();
        Task<RoomEntity> GetById(int id);
        Task<RoomCompleto> AddRoom(RoomCompleto room);
        Task DeleteRoom(int id);
        Task UpdateRoom(RoomCompleto room);
        Task<IEnumerable<RoomEntity>> GetByUser(int id);
        Task<IEnumerable<RoomEntity>> GetByLocality(string locality);
    }
}
