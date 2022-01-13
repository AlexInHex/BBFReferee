using BBFReferee.Core.Enums;
using System.Collections.Generic;

namespace BBFReferee.Core.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public Gender GenderId { get; set; }
        public string Name { get; set; }

        //public int HomeTeamId { get; set; }
        //public int AwayTeamId { get; set; }

        public ICollection<GameTeam> Games { get; set; }

    }
}
