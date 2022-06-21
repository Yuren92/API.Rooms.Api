using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Contracts.Entities
{
    public class RoomEntity
    {
        public int id { get; set; }
        public string street { get; set; }
        public int number { get; set; }
        public string? floor_letter { get; set; }
        public string locality { get; set; }
        public int postcode { get; set; }
        public string province { get; set; }
        public string country { get; set; }
        public int roommate_gender { get; set; }
        public int bed_type { get; set; }
        public bool is_furnished { get; set; }
        public bool has_private_bath { get; set; }
        public bool has_private_view { get; set; }
        public string room_description { get; set; }
        public bool has_internet { get; set; }
        public bool has_elevator { get; set; }
        public bool has_whashing_machine { get; set; }
        public bool has_drying_machine { get; set; }
        public bool has_dishwasher { get; set; }
        public bool has_garden { get; set; }
        public bool has_balcony { get; set; }
        public bool has_heating { get; set; }
        public bool has_doorman { get; set; }
        public bool is_accessibility { get; set; }
        public bool has_parking { get; set; }
        public bool has_air_conditioning { get; set; }
        public bool room_smoke { get; set; }
        public bool room_pet { get; set; }
        public bool room_couples { get; set; }
        public double price { get; set; }
        public int userId { get; set; }
        public UserEntity user { get; set; }


    }
}
