﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.EFModels
{
    public partial class ExtraService
    {
        public ExtraService()
        {
            ExtraServiceImages = new HashSet<ExtraServiceImage>();
            ExtraServiceProducts = new HashSet<ExtraServiceProduct>();
            OrderExtraServicesDetails = new HashSet<OrderExtraServicesDetail>();
            PackageTours = new HashSet<PackageTour>();
        }

        public int Id { get; set; }
        public int RegionId { get; set; }
        public int AttractionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }

        public virtual Attraction Attraction { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<ExtraServiceImage> ExtraServiceImages { get; set; }
        public virtual ICollection<ExtraServiceProduct> ExtraServiceProducts { get; set; }
        public virtual ICollection<OrderExtraServicesDetail> OrderExtraServicesDetails { get; set; }

        public virtual ICollection<PackageTour> PackageTours { get; set; }
    }
}