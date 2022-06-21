using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Business.Models
{
    public class UserCompleto
    {
        public UserCompleto(int id, string name, string email, string? pass, string? phone,
            string about, string locality, int num_roommate, int bed_type, int? gender,
            bool has_internet, bool has_elevator, bool has_whashing_machine, bool has_drying_machine,
            bool has_dishwasher, bool has_garden, bool has_balcony, bool has_doorman, bool has_parking,
            bool has_heating, bool is_accessibility, bool has_air_conditioning, bool is_furnished,
            bool user_smoke, bool user_pet, bool user_vegan, bool room_smoke, bool room_pet, int age,
            bool studing, bool working, int roommate_gender, bool has_private_bath,
            bool has_private_view, bool room_couples)
        {
            this.id = id;
            this.name = name;
            this.email = email; 
            this.gender = gender;
            this.phone = phone;
            this.password = pass;
            //this.professional_area = profarea;
            this.age = age;
            this.about_me = about;
            this.locality = locality;
            this.num_roommate = num_roommate;
            this.bed_type = bed_type;
            this.has_internet = has_internet;
            this.has_elevator = has_elevator;
            this.has_whashing_machine = has_whashing_machine;
            this.has_drying_machine = has_drying_machine;
            this.has_dishwasher = has_dishwasher;
            this.has_balcony = has_balcony;
            this.has_air_conditioning = has_air_conditioning;
            this.has_garden = has_garden;
            this.has_balcony = has_balcony;
            this.has_doorman = has_doorman;
            this.has_parking = has_parking;
            this.has_heating = has_heating;
            this.is_accessibility = is_accessibility;
            this.is_furnished = is_furnished;
            this.user_pet = user_pet;
            this.user_smoke = user_smoke;  
            this.user_vegan = user_vegan;
            this.room_pet = room_pet;
            this.room_smoke = room_smoke;
            this.studing = studing;
            this.working = working;
            this.roommate_gender = roommate_gender;
            this.room_couples = room_couples;
            this.has_private_bath = has_private_bath;
            this.has_private_view = has_private_view;

        }
        public UserCompleto()
        {
         
        }
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
