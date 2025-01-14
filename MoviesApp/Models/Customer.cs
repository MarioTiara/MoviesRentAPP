﻿using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MoviesApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Please enter customer's name ")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscirbedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name="Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name="Date of Birth")]
        [Min18IfAMember]
        public DateTime? BirthDate { get; set; }
    }
}