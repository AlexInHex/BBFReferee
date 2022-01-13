using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class AdressTeamConfiguration : IEntityTypeConfiguration<AdressTeam>
    {
        public void Configure(EntityTypeBuilder<AdressTeam> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.SityId)
                .IsRequired();

            builder
                .Property(X => X.Adress)
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(x => x.TeamId)
                .IsRequired();

          
        }
    }
}
