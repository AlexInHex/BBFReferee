using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BBFReff.Entities;
using BBFReferee.Core.Entities;
using BBFReferee.Infrastructure.Data.Configuration;

namespace BBFReferee.Infrastructure.Data
{
    public class BBFRefereeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Sity> Sities { get; set; }
        public DbSet<AdressTeam> Adresses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<RefereeTeam> RefereeTeams { get; set; }

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=BBFReferee;Trusted_Connection=True;");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new GameConfiguration().Configure(modelBuilder.Entity<Game>());
        new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
        new SeasonConfiguration().Configure(modelBuilder.Entity<Season>());
        new SityConfiguration().Configure(modelBuilder.Entity<Sity>());
        new UserConfiguration().Configure(modelBuilder.Entity<User>());

    }
}
