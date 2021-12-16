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

            builder
                .Property(t => t.HomeTeam)
                .IsRequired();

            builder
                .Property(t => t.AwayTeam)
                .IsRequired();

            builder
                .Property(t => t.RefereeTeams)
                .IsRequired();

            builder
                .Property(t => t.Describtion)
                .HasMaxLength(300);

        }
    }
}
