using System.ComponentModel.DataAnnotations;

namespace Room_Mates.Core.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Ocupation { get; set; }
        [Required]
        public string Address { get; set; }             // Where do you want to live?
        [Required]
        public string MaxRentMonth { get; set; }        // $/month
        public string MovingDate { get; set; }
        public string Comentarios { get; set; }         // Add a comentars about what you looking for..
    }
}