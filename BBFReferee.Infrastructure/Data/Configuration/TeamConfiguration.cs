using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {

        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder
                .Property(x => x.GenderId)
                .IsRequired();

            builder
                .HasMany(x => x.Adresses)
                .WithOne(y => y.Team)
                .OnDelete(DeleteBehavior.Restrict);

          //  builder
          //      .Property(t => t.HomeTeamId)
          //      .IsRequired();
          // 
          //  builder
          //      .Property(t => t.AwayTeamId)
          //      .IsRequired();

        }
    }
}
