using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class AdressTeamConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(X => X.Adds)
                .HasMaxLength(200)
                .IsRequired();




        }
    }
}
