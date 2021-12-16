using BBFReferee.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReff.Entities
{
    public class RefereeTeam
    {
        public RoleOnGame RoleInGame { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Mark { get; set; }
        public int ReportId { get; set; }
        public Report Report { get; set; }
        public int Id { get; set; }



    }
}
