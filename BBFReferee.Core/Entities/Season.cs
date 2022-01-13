using System;
using System.Collections.Generic;

namespace BBFReferee.Core.Entities
{
    public class Season
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartSeason { get; set; }
        public DateTime EndSeason { get; set; }
        public  ICollection<Game> Games { get; set; }


    }
}
