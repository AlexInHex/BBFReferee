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
    internal class AdressTeamConfiguration : IEntityTypeConfiguration<AdressTeam>
    {
        public void Configure(EntityTypeBuilder<AdressTeam> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.SityId)
                .IsRequired();

            builder
                .Property(X => X.Adress)
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(x => x.TeamId)
                .IsRequired();

           // builder
           //     .HasOne(x => x.TeamId)
           //     .WithMany(x => x.Adresses)
           //     .OnDelete(DeleteBehavior.SetNull);
           //
        }
    }
}
