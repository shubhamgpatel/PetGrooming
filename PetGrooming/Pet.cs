﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetGrooming.Models
{
    public class Pet
    {
        /*
            A pet is an animal that receives the grooming that the owner pays for
            Some things that describe a pet:
                - Name
                - Weight
                - Species
                - Color
                - Special Notes

            A Pet must reference a Species
        */
        [Key]
        public int PetID { get; set; }
        public string PetName { get; set; }
        public double Weight { get; set; }
        public string Color { get; set; }
       // public string Notes { get; set; }
        public int PetAge { get; set; }
        public DateTime PetDOB{ get; set; }
        /*
        public int pet_id { get; set; }
        public string pet_name { get; set; }
        public double pet_weight { get; set; }
        public string pet_color { get; set; }
        public int pet_age { get; set; }
        public DateTime pet_DOB { get; set; }
    */



        //Representing the Many in (One species to Many Pets)

        public int SpeciesID { get; set; }
        [ForeignKey("SpeciesID")]
        public virtual Species Species { get; set; }
    }
}