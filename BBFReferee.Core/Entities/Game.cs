using System;
using System.Collections.Generic;

namespace BBFReferee.Core.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public int Sity { get; set; }
        public DateTime DateOfGame { get; set; }
        public ICollection<GameTeam> Teams { get; set; }
        public int RefereeId { get; set; }
        public string Describtion { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }  
        public int GameNumberInSeasonId { get; set; }
        
    }
}
