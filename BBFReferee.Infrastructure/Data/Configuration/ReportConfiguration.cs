using BBFReff.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Report> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.GameId)
                .IsRequired();

            builder
                .Property(x => x.UserId)
                .IsRequired();

            builder
                .Property(x => x.DateCreation)
                .IsRequired();

            builder
                .Property(x => x.Describtion)
                .HasMaxLength(300);

       
        }
    }
}
