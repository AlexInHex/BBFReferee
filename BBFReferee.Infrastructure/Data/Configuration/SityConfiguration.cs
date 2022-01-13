using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class SityConfiguration : IEntityTypeConfiguration<Sity>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Sity> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
