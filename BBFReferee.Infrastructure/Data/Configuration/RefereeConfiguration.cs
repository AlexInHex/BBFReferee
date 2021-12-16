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
                .Property(x => x.ReportId)
                .IsRequired();
        }
    }
}
