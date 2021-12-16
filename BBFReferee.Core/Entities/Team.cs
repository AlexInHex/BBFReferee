using BBFReferee.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReff.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public Gender GenderId { get; set; }
        public string Name { get; set; }
        public ICollection<AdressTeam> Adresses { get; set; }
        public ICollection<Game> HomeGames { get; set; }
        public ICollection<Game> AwayGames { get; set; }


    }
}
