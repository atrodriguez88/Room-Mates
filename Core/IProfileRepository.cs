using System.Collections.Generic;
using System.Threading.Tasks;
using Room_Mates.Core.Models;

namespace Room_Mates.Core
{
    public interface IProfileRepository
    {
        Task<Profile> GetProfile(int id, bool? includeRelated = true);
        Task<List<Profile>> GetProfiles();

        Task AddProfileAsync(Profile profile);
        void Remove(Profile profile);
    }
}