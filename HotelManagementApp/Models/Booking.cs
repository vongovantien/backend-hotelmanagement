﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace HotelManagementApp.Models
{
    public partial class Booking
    {
        public Guid Id { get; set; }
        public Guid RoodId { get; set; }
        public DateTime? BookingDate { get; set; }
        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Room Rood { get; set; }
    }
}