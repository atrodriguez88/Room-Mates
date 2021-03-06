using System;
using Room_Mates.Core.Models;

namespace Room_Mates.Controllers.Resources
{
    public class ProfileResource
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int OcupationId { get; set; }
        // public OcupationResource Ocupation { get; set; }
        public string Address { get; set; }  
        public string MaxRentMonth { get; set; }
        public DateTime MovingDate { get; set; }
        public string Comentarios { get; set; }
        public int UserId { get; set; }
        // public ApplicationUser User { get; set; }
    }
}