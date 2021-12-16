using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBFReff.Entities;

namespace BBFReferee.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Login)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(t => t.Password)
                .HasMaxLength(50)
                .IsFixedLength()
                .IsRequired();

            builder
                .Property(t => t.Name)
                .HasMaxLength(40)
                .IsRequired();

            builder
                .Property(t => t.Surname)
                .HasMaxLength(40)
                .IsRequired();

            builder
                .Property(t => t.Patronymic)
                .HasMaxLength(40);

            builder
                .Property(t => t.DayOfBirth)
                .IsRequired();

            builder
                .Property(t => t.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(t => t.SityId)
                .IsRequired();

            builder
                .Property(t => t.DateRegistration)
                .IsRequired();

            builder
                .Property(t => t.GenderId)
                .IsRequired();
        }
    }
}
