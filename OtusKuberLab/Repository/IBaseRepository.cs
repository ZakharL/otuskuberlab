using System.Threading.Tasks;

namespace OtusKuberLab.Repository
{
    public interface IBaseRepository<in TEntity>
        where TEntity : class
    {
        Task AddAsync( TEntity entity );

        Task RemoveAsync( TEntity entity );

        Task UpdateAsync( TEntity entity );
    }
}
