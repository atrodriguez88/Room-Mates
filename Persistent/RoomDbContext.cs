using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Room_Mates.Core.Models;

namespace Room_Mates.Persistent
{
    public class RoomDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public RoomDbContext(DbContextOptions<RoomDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Many to Many
            modelBuilder.Entity<RoomsPropertyRules>()
                .HasKey(rp => new { rp.RoomId, rp.PropertyRulesId });

            modelBuilder.Entity<RoomsPropertyFeatures>()
                .HasKey(rf => new { rf.RoomId, rf.PropertyFeaturesId });

            modelBuilder.Entity<RoomRoomFeatures>()
                .HasKey(rf => new { rf.RoomId, rf.RoomFeaturesId });
        }
    }
}