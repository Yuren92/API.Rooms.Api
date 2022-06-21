using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Rooms.DataAccess.Contracts;
using Rooms.DataAccess.Contracts.Entities;
using Rooms.DataAccess.EntityConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess
{
    public class RoomsDBContext : DbContext, IRoomsDBContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }

        public RoomsDBContext(DbContextOptions options) : base(options) { }

        public RoomsDBContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            UserEntityConfig.SetEntityBuilder(modelBuilder.Entity<UserEntity>());
            RoomEntityConfig.SetEntityBuilder(modelBuilder.Entity<RoomEntity>());

            base.OnModelCreating(modelBuilder);
        }
    }
}
