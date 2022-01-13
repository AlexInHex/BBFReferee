using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class RefereeConfiguration : IEntityTypeConfiguration<Referee>
    {
        public void Configure(EntityTypeBuilder<Referee> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x=> x.GameId)
                .IsRequired();

            builder
                .Property(x => x.UserId)
                .IsRequired();

            builder
                .Property(x => x.Mark)
                .HasMaxLength(3);

            builder
                .HasMany(x=> x.Reports)
                .WithOne(y=> y.Referee)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
