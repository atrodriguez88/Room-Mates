using System.Collections.Generic;
using System.Threading.Tasks;
using Room_Mates.Core.Models;

namespace Room_Mates.Core
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetRooms();
        Task<Room> GetRoom(int id, bool? includeRelated = true);
        Task AddRoomAsync(Room room);
        void Remove(Room room);
    }
}