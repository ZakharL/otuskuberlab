using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OtusKuberLab.Models;

namespace OtusKuberLab.Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure( EntityTypeBuilder<User> builder )
        {
            builder.ToTable( nameof( User ) )
                .HasKey( user => new
                {
                    user.UserId
                } );

            builder.Property( user => user.UserId )
                .ValueGeneratedOnAdd();

            builder.Property( user => user.Name )
                .IsRequired();
        }
    }
}
