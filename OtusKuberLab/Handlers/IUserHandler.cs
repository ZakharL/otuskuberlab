using System.Threading.Tasks;
using OtusKuberLab.Dtos;

namespace OtusKuberLab.Handlers
{
    public interface IUserHandler
    {
        Task<User> AddUser( User user );

        Task DeleteUser( int id );

        Task<User> UpdateUser( int id, User user );

        Task<User> GetUser( int id );
    }
}
