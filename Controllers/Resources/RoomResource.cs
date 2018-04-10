using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Room_Mates.Controllers.Resources
{
    public class RoomResource
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public PropertyTypeResource PropertyType { get; set; }
        public int NumberBedrooms { get; set; }
        public int NumberBathrooms { get; set; }
        public int RoomsToRent { get; set; }
        public ICollection<PropertyFeaturesResource> PropertyFeatures { get; set; }
        public ICollection<PropertyRulesResource> Rules { get; set; }
        public float RentPerMonth { get; set; }
        public bool IsUtilityIncluded { get; set; }
        public string RoomType { get; set; }
        public float RoomSquareMeters { get; set; }
        public bool IsFurnished { get; set; }
        public ICollection<RoomFeaturesResource> RoomFeatures { get; set; }
        public DateTime AvailableFrom { get; set; }
        public int MinStayMonths { get; set; }

        public int PrefMaxAge { get; set; }
        public string Smoking { get; set; }
        public string Pet { get; set; }             // Dog(s) ok, Cat(s) ok, Caged Pet(s) ok,
        public string Cleanliness { get; set; }     // Clean, Average, Messy
        /* ************ Current Roommates ***************** */
        public int NumberRoomatesAlready { get; set; }

        /* ************ Preferred Roommates ***************** */
        public string PrefGender { get; set; }
        public int OcupationId { get; set; }
        public OcupationResource PrefOcuppations { get; set; }
        public int PrefMinAge { get; set; }

        public int UserId { get; set; }
        // public ApplicationUser User { get; set; }
        // public Photo Photos { get; set; }
        public RoomResource()
        {
            Rules = new Collection<PropertyRulesResource>();
            PropertyFeatures = new Collection<PropertyFeaturesResource>();
            RoomFeatures = new Collection<RoomFeaturesResource>();
        }
    }
}