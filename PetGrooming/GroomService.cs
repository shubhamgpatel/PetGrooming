﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomService
    {
        /*
            A GroomService is a type of activity that a Groomer can do for a pet. Some examples might be nail clipping, shampoo, trim, etc.
            
            Some things that describe a GroomService
                - Service Name
                - Cost
                - Duration
         */
        [Key]
        public int groomer_service_id { get; set; }
        public string groomer_serviceName { get; set; }
        public DateTime groomer_service_duration { get; set; }
        public float groomer_cost { get; set; }
    }
}