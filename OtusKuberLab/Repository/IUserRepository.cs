using System.Threading.Tasks;
using OtusKuberLab.Models;

namespace OtusKuberLab.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUserAsync( int userId );
    }
}
