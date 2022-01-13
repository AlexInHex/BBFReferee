using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class SeasonConfiguration : IEntityTypeConfiguration<Season>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Season> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .HasMaxLength(50);

            builder
                .Property(t => t.StartSeason)
                .IsRequired();

            builder
                .Property(t => t.EndSeason)
                .IsRequired();
               
        }
    }
}
