namespace Room_Mates.Core.Models
{
    public class PropertyRules
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}