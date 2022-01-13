using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class GameTeamConfiguration : IEntityTypeConfiguration<GameTeam>
    {
        public void Configure(EntityTypeBuilder<GameTeam> builder)
        {
            builder
                .HasKey(x => new { x.TeamId, x.GameId });

        }
    }
}
