using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReff.Entities
{
    public class GameSeason
    {
        public int GameId { get; set; }
        public int SeasonId { get; set; }
        public int GameInSeasonId { get; set; }
        public Game Game { get; set; }
        public Season Season { get; set; }

    }
}
