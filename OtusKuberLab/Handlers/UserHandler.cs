using System.Threading.Tasks;
using OtusKuberLab.Dtos;
using OtusKuberLab.Repository;
using OtusKuberLab.Services.Converters;

namespace OtusKuberLab.Handlers
{
    public class UserHandler : IUserHandler
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserConverter _userConverter;

        public UserHandler(
            IUserRepository userRepository,
            IUserConverter userConverter )
        {
            _userRepository = userRepository;
            _userConverter = userConverter;
        }

        public async Task<User> AddUser( User user )
        {
            await _userRepository.AddAsync( _userConverter.Convert( user ) ).ConfigureAwait( false );

            return user;
        }

        public async Task DeleteUser( int id )
        {
            Models.User user = await _userRepository.GetUserAsync( id ).ConfigureAwait( false );

            if ( user != null )
            {
                await _userRepository.RemoveAsync( user ).ConfigureAwait( false );
            }
        }

        public async Task<User> GetUser( int id )
        {
            Models.User user = await _userRepository.GetUserAsync( id ).ConfigureAwait( false );

            return _userConverter.Convert( user );
        }

        public async Task<User> UpdateUser( int id, User user )
        {
            Models.User dbUser = await _userRepository.GetUserAsync( id ).ConfigureAwait( false );

            if ( dbUser != null )
            {
                dbUser.Name = user.Name;
                dbUser.FirstName = user.FirstName;
                dbUser.LastName = user.LastName;
                dbUser.Email = user.Email;
                dbUser.Phone = user.Phone;

                await _userRepository.UpdateAsync( dbUser ).ConfigureAwait( false );
            }

            return _userConverter.Convert( dbUser );
        }
    }
}
