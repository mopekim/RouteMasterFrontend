﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.EFModels
{
    public partial class CommentStatus
    {
        public CommentStatus()
        {
            CommentsAccommodations = new HashSet<CommentsAccommodation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CommentsAccommodation> CommentsAccommodations { get; set; }
    }
}