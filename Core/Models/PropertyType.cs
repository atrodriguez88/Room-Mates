using System.ComponentModel.DataAnnotations.Schema;

namespace Room_Mates.Core.Models
{
    [Table("PropertyTypes")]
    public class PropertyType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    // Apartment, House, Studio
}