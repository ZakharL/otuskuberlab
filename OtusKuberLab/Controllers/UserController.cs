using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OtusKuberLab.Dtos;
using OtusKuberLab.Handlers;

namespace OtusKuberLab.Controllers
{
    [ApiController]
    [Route( "[controller]" )]
    public class UserController
    {
        public readonly IUserHandler _userHandler;

        public UserController( IUserHandler userHandler )
        {
            _userHandler = userHandler;
        }

        [HttpGet]
        [Route( "{id}" )]
        public async Task<User> Get( int id )
        {
            return await _userHandler.GetUser( id ).ConfigureAwait( false );
        }

        [HttpDelete]
        [Route( "{id}" )]
        public async Task<ActionResult> Delete( int id )
        {
            await _userHandler.DeleteUser( id ).ConfigureAwait( false );

            return new NoContentResult();
        }

        [HttpPut]
        [Route( "{id}" )]
        public async Task<User> Update( int id, [FromBody] User user )
        {
            return await _userHandler.UpdateUser( id, user ).ConfigureAwait( false );
        }

        [HttpPost]
        public async Task<User> Post( User user )
        {
            return await _userHandler.AddUser( user ).ConfigureAwait( false );
        }
    }
}
