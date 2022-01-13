using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Sity)
                .IsRequired();

            builder
                .Property(t => t.DateOfGame)
                .IsRequired();

            builder
                .Property(t => t.RefereeId)
                .IsRequired();

            builder
                .Property(t => t.Describtion)
                .HasMaxLength(300);

            builder
               .HasOne(t => t.Season)
               .WithMany(x => x.Games)
               .OnDelete(DeleteBehavior.Restrict);

            builder
               .Property(x => x.GameNumberInSeasonId)
               .IsRequired();

         
        }
    }
}
