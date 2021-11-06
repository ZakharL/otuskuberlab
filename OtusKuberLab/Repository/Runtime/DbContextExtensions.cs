using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace OtusKuberLab.Repository.Runtime
{
    public static class DbContextExtensions
    {
        public static IServiceCollection AddOtusKuberLabDbContext(
            this IServiceCollection services,
            string connectionString )
        {
            services.AddDbContext<OtusKuberLabDbContext>(
                options =>
                {
                    options.UseSqlServer(
                        connectionString,
                        sqlServerOption =>
                        {
                            sqlServerOption.UseQuerySplittingBehavior( QuerySplittingBehavior.SplitQuery );
                        } );
                } );

            return services;
        }
    }
}
