﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.EFModels
{
    public partial class OrderAccommodationDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int AccommodationId { get; set; }
        public string AccommodationName { get; set; }
        public int RoomProductId { get; set; }
        public string RoomType { get; set; }
        public string RoomName { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int? RoomPrice { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }

        public virtual Accommodation Accommodation { get; set; }
        public virtual Order Order { get; set; }
        public virtual RoomProduct RoomProduct { get; set; }
    }
}