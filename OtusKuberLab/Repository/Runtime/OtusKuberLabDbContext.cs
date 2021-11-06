using Microsoft.EntityFrameworkCore;
using OtusKuberLab.Models;
using OtusKuberLab.Repository.Configuration;

namespace OtusKuberLab.Repository.Runtime
{
    public class OtusKuberLabDbContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }

        public OtusKuberLabDbContext( DbContextOptions<OtusKuberLabDbContext> options )
            : base( options )
        {
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfiguration( new UserConfiguration() );
        }
    }
}
