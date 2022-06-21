using Rooms.Business.Models;
using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Mappers
{
    public static class UserMapper
    {
        public static UserEntity Map(UserCompleto dto)
        {
            return new UserEntity()
            {
                id = dto.id,
                name = dto.name,
                about_me = dto.about_me,
                email = dto.email,
                gender = dto.gender,
                password = dto.password,
                phone = dto.phone,
               // professional_area = dto.professional_area,
                age = dto.age,
                locality = dto.locality,
                num_roommate = dto.num_roommate,
                bed_type = dto.bed_type,
                has_air_conditioning = dto.has_air_conditioning,
                has_balcony = dto.has_balcony,
                has_dishwasher = dto.has_dishwasher,
                has_doorman = dto.has_doorman,
                has_drying_machine = dto.has_drying_machine,
                has_elevator = dto.has_elevator,
                has_garden = dto.has_garden,
                has_heating = dto.has_heating,
                has_internet = dto.has_internet,
                has_parking = dto.has_parking,
                has_whashing_machine = dto.has_whashing_machine,
                is_accessibility = dto.is_accessibility,
                is_furnished = dto.is_furnished,
                user_pet = dto.user_pet,
                user_smoke = dto.user_smoke,
                user_vegan = dto.user_vegan,
                room_pet = dto.room_pet,
                room_smoke = dto.room_smoke,
                working = dto.working,
                studing = dto.studing,
                roommate_gender = dto.roommate_gender,
                has_private_view = dto.has_private_view,
                has_private_bath = dto.has_private_bath,
                room_couples = dto.room_couples
            };
        }
    }
}

