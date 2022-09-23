using System.ComponentModel.DataAnnotations;
using CoreMVC.Model;
using Microsoft.AspNetCore.Identity;

namespace RunGroopWebApp.Models
{
    public class AppUser : IModel
    {
        [Key]
        public int Id { get; set; }
        public int? Pace { get; set; }
        public int? MileAge { get; set; }
        public Address? Address { get; set; }
        public ICollection<Race> Races { get; set; }
        public ICollection<Club> Clubs { get; set; }

    }
}
