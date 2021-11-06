namespace OtusKuberLab.Services.Converters
{
    public class UserConverter : IUserConverter
    {
        public Models.User Convert( Dtos.User user )
        {
            if ( user == null )
            {
                return null;
            }

            return new Models.User()
            {
                Name = user.Name,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email
            };
        }

        public Dtos.User Convert( Models.User user )
        {
            if ( user == null )
            {
                return null;
            }

            return new Dtos.User()
            {
                Name = user.Name,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email
            };
        }
    }
}
