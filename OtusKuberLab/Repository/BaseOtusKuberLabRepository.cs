using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OtusKuberLab.Repository.Runtime;

namespace OtusKuberLab.Repository
{
    public class BaseOtusKuberLabRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly OtusKuberLabDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseOtusKuberLabRepository( OtusKuberLabDbContext context )
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task AddAsync( TEntity entity )
        {
            if ( _context.Entry( entity ).State != EntityState.Added )
            {
                _dbSet.Add( entity );
                await _context.SaveChangesAsync().ConfigureAwait( false );
            }
        }

        public virtual async Task RemoveAsync( TEntity entity )
        {
            _dbSet.Remove( entity );
            await _context.SaveChangesAsync().ConfigureAwait( false );
        }

        public virtual async Task UpdateAsync( TEntity entity )
        {
            _dbSet.Update( entity );
            await _context.SaveChangesAsync().ConfigureAwait( false );
        }
    }
}
