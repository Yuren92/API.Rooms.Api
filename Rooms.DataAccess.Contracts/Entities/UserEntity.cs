using Rooms.DataAccess.Contracts.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.DataAccess.Contracts.Entities
{
    public class UserEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string? phone { get; set; }
        public string? password { get; set; }
        public string about_me { get; set; }
        public bool user_smoke { get; set; }
        public bool user_pet { get; set; }
        public bool user_vegan { get; set; }
        public bool studing { get; set; }
        public bool working { get; set; }
        public int? gender { get; set; }
        public int age { get; set; }


        //public string? professional_area { get; set; }


        //V2 
        public string locality { get; set; }
        public int num_roommate { get; set; }
        public int roommate_gender { get; set; }

        public int bed_type { get; set; }
        public bool is_furnished { get; set; }
        public bool has_private_bath { get; set; }
        public bool has_private_view { get; set; }
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


    }
}
