namespace Room_Mates.Core.Models
{
    public class PropertyFeatures
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}