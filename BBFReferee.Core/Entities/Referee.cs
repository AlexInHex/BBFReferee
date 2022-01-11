using BBFReferee.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReff.Entities
{
    public class Referee
    {
        public RoleOnGame RoleInGame { get; set; }
        public int GameId { get; set; }
        
        public int UserId { get; set; }
        
        public int Mark { get; set; }
        public int ReportId { get; set; }
        
        public int Id { get; set; }



    }
}
