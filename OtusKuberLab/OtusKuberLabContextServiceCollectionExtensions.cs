using Microsoft.Extensions.DependencyInjection;
using OtusKuberLab.Handlers;
using OtusKuberLab.Repository;
using OtusKuberLab.Services.Converters;

namespace OtusKuberLab
{
    public static class OtusKuberLabContextServiceCollectionExtensions
    {
        public static IServiceCollection AddOtusKuberLabContext( this IServiceCollection services )
        {
            AddRepositories( services );
            AddHandlers( services );
            AddConverters( services );

            return services;
        }

        private static void AddRepositories( IServiceCollection services )
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }

        private static void AddConverters( IServiceCollection services )
        {
            services.AddScoped<IUserConverter, UserConverter>();
        }        
        
        private static void AddHandlers( IServiceCollection services )
        {
            services.AddTransient<IUserHandler, UserHandler>();
        }
    }
}
