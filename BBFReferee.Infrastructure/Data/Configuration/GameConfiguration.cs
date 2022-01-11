using BBFReff.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Game> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Sity)
                .IsRequired();

            builder
                .Property(t => t.DateOfGame)
                .IsRequired();

         //  builder
         //      .Property(t => t.HomeTeamId)
         //      .IsRequired();
         //
         //  builder
         //      .HasOne(t => t.Season)
          //     .WithMany(x => x.Games)
          //     .OnDelete(DeleteBehavior.Restrict);

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

            //  builder
            //      .Property(t => t.SeasonId)
            //      .IsRequired();

            builder
               .Property(x => x.GameNumberInSeasonId)
               .IsRequired();

          //  builder
          //      .HasOne(t => t.HomeTeamId).WithMany()
          //      .OnDelete(DeleteBehavior.Cascade);
          //
          //  builder
          //      .HasOne(t => t.AwayTeamId).WithMany()
          //      .OnDelete(DeleteBehavior.Cascade);
          //
        }
    }
}
