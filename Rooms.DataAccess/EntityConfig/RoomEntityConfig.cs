using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.EntityConfig
{
    public class RoomEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<RoomEntity> entityBuilder)
        {
            entityBuilder.ToTable("Rooms");
            entityBuilder.HasKey(x => x.id);
            entityBuilder.Property(x => x.id).IsRequired().ValueGeneratedOnAdd();

            entityBuilder.HasOne(x => x.user).WithMany().HasForeignKey(x => x.userId);
        }
    }
}
