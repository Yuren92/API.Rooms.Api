using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooms.Business.Models
{
    public class RoomCompleto
    {
        public RoomCompleto()
        {

        }

        public RoomCompleto(int id, string room_description, int bed_type,
            double price, string street, int number, string? floor_letter, string locality, string province,
            string country, int postcode, bool is_furnished, bool has_air_conditioning, bool has_internet, bool has_elevator,
            bool has_whashing_machine, bool can_smoke, bool can_pets, bool can_couple, int roommate_gender,
            int userId, bool has_private_bath, bool has_drying_machine, bool has_garden, bool has_balcony,
            bool has_dishwasher, bool has_doorman, bool has_parking, bool has_heating, bool is_accessibility,
            bool has_private_view)
        {
            this.id = id;
            this.room_description = room_description;
            this.bed_type = bed_type;            
            this.price = price;
            this.street = street;
            this.number = number;
            this.floor_letter = floor_letter;
            this.locality = locality;
            this.province = province;
            this.country = country;
            this.postcode = postcode;
            this.is_furnished = is_furnished;
            this.has_air_conditioning = has_air_conditioning;
            this.has_internet = has_internet;
            this.has_whashing_machine = has_whashing_machine;
            this.has_elevator = has_elevator;           
            this.room_smoke = can_smoke;
            this.room_pet = can_pets;
            this.room_couples = can_couple;
            this.userId = userId;
            this.has_private_bath = has_private_bath;
            this.has_drying_machine = has_drying_machine;
            this.has_garden = has_garden;
            this.has_balcony = has_balcony;
            this.has_dishwasher = has_dishwasher;
            this.has_doorman = has_doorman;
            this.has_parking = has_parking;
            this.has_heating = has_heating;
            this.is_accessibility = is_accessibility;
            this.roommate_gender = roommate_gender;
            this.has_private_view = has_private_view;
           


        }
        //Room
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

    }
}
