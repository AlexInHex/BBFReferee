using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReff.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public int Sity { get; set; }
        public DateTime DateOfGame { get; set; }
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public ICollection<RefereeTeam> RefereeTeams { get; set; }
        public string Describtion { get; set; }
        public ICollection<GameSeason> GameSeasons { get; set; }
        




    }
}
