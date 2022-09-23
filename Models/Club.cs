﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoreMVC.Model;
using RunGroopWebApp.Data.Enum;

namespace RunGroopWebApp.Models
{
    public class Club : IModel
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ClubCategory ClubCategory { get; set; }
        public int? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
         
    }
}
