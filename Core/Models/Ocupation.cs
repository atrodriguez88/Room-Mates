using System.ComponentModel.DataAnnotations.Schema;

namespace Room_Mates.Core.Models
{
    [Table("Ocupations")]
    public class Ocupation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}