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
        public int HomeGameId { get; set; }
        public int AwayGameId { get; set; }
        public Game Game { get; set; }




    }
}
