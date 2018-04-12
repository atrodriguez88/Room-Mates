using System.Threading.Tasks;
using Room_Mates.Core;

namespace Room_Mates.Persistent
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RoomDbContext context;
        public UnitOfWork(RoomDbContext context)
        {
            this.context = context;

        }
        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}