using System.Collections.Generic;

namespace Room_Mates.Core.Models
{
    public class PropertyRules
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RoomsPropertyRules> Rooms { get; set; }
    }
}