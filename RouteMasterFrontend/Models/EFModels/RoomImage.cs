﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.EFModels
{
    public partial class RoomImage
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public string Image { get; set; }

        public virtual Room Room { get; set; }
    }
}