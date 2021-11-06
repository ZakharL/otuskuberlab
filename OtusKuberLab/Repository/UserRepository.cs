using System.Threading.Tasks;
using OtusKuberLab.Models;
using OtusKuberLab.Repository.Runtime;

namespace OtusKuberLab.Repository
{
    public class UserRepository : BaseOtusKuberLabRepository<User>, IUserRepository
    {
        private readonly OtusKuberLabDbContext _context;

        public UserRepository( OtusKuberLabDbContext context )
            : base( context )
        {
            _context = context;
        }

        public async Task<User> GetUserAsync( int userId )
        {
            return await _context.User
                .FindAsync( userId )
                .ConfigureAwait( false );
        }
    }
}
