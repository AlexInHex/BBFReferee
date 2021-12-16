using BBFReff.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class GameSeasonConfiguration : IEntityTypeConfiguration<GameSeason>
    {
        public void Configure(EntityTypeBuilder<GameSeason> builder)
        {
                builder
                    .HasKey(x=> new {x.GameId, x.SeasonId});

                builder
                    .Property(x => x.GameInSeasonId)
                    .IsRequired();

                builder
                    .Property(x => x.GameId)
                    .IsRequired();
                
                builder
                    .Property(x => x.SeasonId)
                    .IsRequired();
        }
    }
}
