namespace Room_Mates.Core.Models
{
    public class RoomsPropertyRules
    {
        public int RoomId{ get; set; }
        public int PropertyRulesId { get; set; }
        public Room Room { get; set; }
        public PropertyRules PropertyRules { get; set; }
    }
}