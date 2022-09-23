using System.ComponentModel.DataAnnotations;
using CoreMVC.Model;
namespace RunGroopWebApp.Models
{
    public class Address : IModel
    {
        [Key] 
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
