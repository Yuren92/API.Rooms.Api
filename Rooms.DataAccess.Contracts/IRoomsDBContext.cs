using Microsoft.EntityFrameworkCore;
using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Contracts
{
    public interface IRoomsDBContext
    {
        DbSet<UserEntity> Users { get; set; }
        DbSet<RoomEntity> Rooms { get; set; }
    }
}
