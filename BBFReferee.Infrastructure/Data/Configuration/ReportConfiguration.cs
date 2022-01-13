using BBFReferee.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Report> builder)
        {
            builder
                .HasKey(x => x.Id);

           

            builder
                .Property(x => x.DateCreation)
                .IsRequired();

            builder
                .Property(x => x.Describtion)
                .HasMaxLength(300);

       
        }
    }
}
