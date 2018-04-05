using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Room_Mates.Core.Models
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        /* ************* About Property ************* */
        public string PropertyType { get; set; }        // Apartment, House, Studio
        [Required]
        public int NumberBedrooms { get; set; }
        public int NumberBathrooms { get; set; }
        public int RoomsToRent { get; set; }
        // public ICollection<PropertyFeatures> Features { get; set; }
        // public ICollection<PropertyRules> Rules { get; set; }

        /* ************ About Room ***************** */
        [Required]
        public float RentPerMonth { get; set; }
        public bool IsUtilityIncluded { get; set; }     // En caso ke si add "Utility costs per month ($)"
        [Required]
        [StringLength(50)]
        public string RoomType { get; set; }            // Single Room, Double, Shared
        public float RoomSquareMeters { get; set; }
        [Required]
        public bool IsFurnished { get; set; }
        public bool IsEnsuiteBathroom { get; set; }
        public DateTime AvailableFrom { get; set; }
        public int MinStayMonths { get; set; }

        /* ************ Current Roommates ***************** */
        public int NumberRoomatesAlready { get; set; }

        /* ************ Preferred Roommates ***************** */
        public string PrefGender { get; set; }
        public string PrefOcuppation { get; set; }
        public int PrefMinAge { get; set; }
        public int PrefMaxAge { get; set; }
        // public ApplicationUser User { get; set; }
        // public int UserId { get; set; }
        public Room()
        {
            // user.
        }

    }
}