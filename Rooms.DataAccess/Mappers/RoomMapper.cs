using Rooms.Business.Models;
using Rooms.DataAccess.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Mappers
{
    public static class RoomMapper
    {
        public static RoomEntity Map(RoomCompleto dto)
        {
            return new RoomEntity()
            {
                id = dto.id,
                bed_type = dto.bed_type,
                room_couples = dto.room_couples,
                room_pet = dto.room_pet,
                room_smoke = dto.room_smoke,
                country = dto.country,
                floor_letter = dto.floor_letter,
                has_air_conditioning = dto.has_air_conditioning,
                has_elevator = dto.has_elevator,
                has_internet = dto.has_internet,
                has_whashing_machine = dto.has_whashing_machine,
                is_furnished = dto.is_furnished,
                locality = dto.locality,
                number = dto.number,
                postcode = dto.postcode,
                price = dto.price,
                province = dto.province,
                room_description = dto.room_description,
                street = dto.street,
                userId = dto.userId,
                has_heating = dto.has_heating,
                has_parking = dto.has_parking,
                has_doorman = dto.has_doorman, 
                has_dishwasher = dto.has_dishwasher,
                has_balcony = dto.has_balcony,
                has_garden = dto.has_garden,
                has_drying_machine = dto.has_drying_machine,
                has_private_bath = dto.has_private_bath,
                is_accessibility = dto.is_accessibility,
                roommate_gender = dto.roommate_gender,
                has_private_view = dto.has_private_view
            };
        }
    }
}

