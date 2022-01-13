using BBFReferee.Core.Entities;
using BBFReferee.Infrastructure.Data.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BBFReferee.Infrastructure.Data
{
    public class BBFRefereeDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Referee> RefereeTeams { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        public BBFRefereeDbContext(DbContextOptions<BBFRefereeDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new GameConfiguration().Configure(modelBuilder.Entity<Game>());
            new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
            new SeasonConfiguration().Configure(modelBuilder.Entity<Season>());
            new UserConfiguration().Configure(modelBuilder.Entity<User>());
            new AdressTeamConfiguration().Configure(modelBuilder.Entity<Adress>());
            new ReportConfiguration().Configure(modelBuilder.Entity<Report>());
            new TeamConfiguration().Configure(modelBuilder.Entity<Team>());
            new UserRoleConfiguration().Configure(modelBuilder.Entity<UserRole>());
            new GameTeamConfiguration().Configure(modelBuilder.Entity<GameTeam>());
        }
    }
}
