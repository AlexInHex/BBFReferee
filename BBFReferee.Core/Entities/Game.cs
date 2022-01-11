﻿using System;
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
        public ICollection<Team> Teams { get; set; }
        public int RefereeId { get; set; }
        public string Describtion { get; set; }
        public int SeasonId { get; set; }
        public Season Season { get; set; }  
        public int GameNumberInSeasonId { get; set; }
        
    }
}
