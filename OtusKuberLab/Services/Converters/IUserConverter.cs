namespace OtusKuberLab.Services.Converters
{
    public interface IUserConverter
    {
        Models.User Convert( Dtos.User user );
        Dtos.User Convert( Models.User user );
    }
}
