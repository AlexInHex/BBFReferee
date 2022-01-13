using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Role> builder)
        {
            builder
                .HasKey(t=> t.Id);

            builder
                .Property(t => t.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(t => t.Description)
                .HasMaxLength(300);
        }
    }
}
