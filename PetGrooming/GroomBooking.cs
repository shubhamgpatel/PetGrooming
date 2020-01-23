using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        /*
            A GroomBooking is an agreement between an owner and a groomer to provide services for a pet
            
            Some things that describe a GroomBooking
                - A date and time
                - Price
            
            A GroomBooking must reference
                - A Groomer
                - A Pet
                - An Owner
                - A list of GroomServices
                
        */
        [Key]
        public int groomer_booking_id { get; set; }
        public DateTime appointment_date { get; set; }
       
        public int groomer_bridge_id { get; set; }
        [ForeignKey("groomer_bridge_id")]
        public virtual Groomer Groomer{ get; set; }


        public int SpeciesID { get; set; }
        
        

        public int pet_id { get; set; }
        [ForeignKey("pet_id")]
        public virtual Species Species { get; set; }


    }
}