using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Room_Mates.Core;
using Room_Mates.Core.Models;

namespace Room_Mates.Persistent
{
    public class RoomRepository : IRoomRepository
    {
        private readonly RoomDbContext context;
        public RoomRepository(RoomDbContext context)
        {
            this.context = context;
        }

        public async Task AddRoomAsync(Room room)
        {
            await context.Rooms.AddAsync(room);
        }

        public async Task<Room> GetRoom(int id, bool? includeRelated = true)
        {
            if (!includeRelated.Value)
            {
                return await context.Rooms.FindAsync(id);
            }
            var room = await context.Rooms
             .Include(r => r.Rules)
                 .ThenInclude(rpr => rpr.PropertyRules)
             .Include(r => r.PropertyFeatures)
                 .ThenInclude(rpf => rpf.PropertyFeatures)
             .Include(r => r.RoomFeatures)
                 .ThenInclude(rrf => rrf.RoomFeatures).SingleOrDefaultAsync(r => r.Id == id);

            return room;
        }

        public async Task<List<Room>> GetRooms()
        {
            var rooms = await context.Rooms
             .Include(r => r.Rules)
                 .ThenInclude(rpr => rpr.PropertyRules)
             .Include(r => r.PropertyFeatures)
                 .ThenInclude(rpf => rpf.PropertyFeatures)
             .Include(r => r.RoomFeatures)
                 .ThenInclude(rrf => rrf.RoomFeatures).ToListAsync();

            return rooms;
        }

        public void Remove(Room room)
        {
            context.Remove(room);
        }
    }
}