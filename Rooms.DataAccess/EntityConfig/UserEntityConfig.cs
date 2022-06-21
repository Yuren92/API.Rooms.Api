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
    public class UserEntityConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<UserEntity> entityBuilder)
        {
            entityBuilder.ToTable("Users");
            entityBuilder.HasKey(x => x.id);
            entityBuilder.Property(x => x.id).IsRequired().ValueGeneratedOnAdd();
            entityBuilder.Property(x => x.email).IsRequired();
            entityBuilder.HasIndex(u => u.email).IsUnique();
        }
    }
}
