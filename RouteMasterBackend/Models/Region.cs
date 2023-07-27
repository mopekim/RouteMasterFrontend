﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterBackend.Models
{
    public partial class Region
    {
        public Region()
        {
            Accommodations = new HashSet<Accommodation>();
            Activities = new HashSet<Activity>();
            Attractions = new HashSet<Attraction>();
            ExtraServices = new HashSet<ExtraService>();
            Towns = new HashSet<Town>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Accommodation> Accommodations { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Attraction> Attractions { get; set; }
        public virtual ICollection<ExtraService> ExtraServices { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
    }
}