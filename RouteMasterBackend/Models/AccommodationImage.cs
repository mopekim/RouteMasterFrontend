﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterBackend.Models
{
    public partial class AccommodationImage
    {
        public int Id { get; set; }
        public int AccommodationId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Accommodation Accommodation { get; set; }
    }
}