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
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IEnumerable<RoomEntity>> GetAll()
        {
            return await _roomRepository.GetAll();

        }

        public async Task<RoomEntity> GetById(int id)
        {
            return await _roomRepository.GetById(id);
        }

        public async Task<RoomCompleto> AddRoom(RoomCompleto room)
        {
            await _roomRepository.Add(RoomMapper.Map(room));
            return room;
        }
        public Task DeleteRoom(int id)
        {
            var room = _roomRepository.GetById(id);
            _roomRepository.Remove(room.Result);
            return Task.CompletedTask;
        }

        public async Task UpdateRoom(RoomCompleto room)
        {
            await _roomRepository.Update(RoomMapper.Map(room));
        }

        public async Task<IEnumerable<RoomEntity>> GetByUser(int id)
        {
             return await _roomRepository.GetRoomsFromUser(id);
        }
        public async Task<IEnumerable<RoomEntity>> GetByLocality(string locality)
        {
            return await _roomRepository.GetRoomsFromLocality(locality);
        }
    }
}
