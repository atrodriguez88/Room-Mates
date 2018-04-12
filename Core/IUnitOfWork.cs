using System.Threading.Tasks;

namespace Room_Mates.Core
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}