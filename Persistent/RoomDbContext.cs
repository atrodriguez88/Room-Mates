using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Room_Mates.Core.Models;

namespace Room_Mates.Persistent
{
    public class RoomDbContext : IdentityDbContext<ApplicationUser>
    {
        public RoomDbContext(DbContextOptions<RoomDbContext> options)
            : base(options)
        {
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}