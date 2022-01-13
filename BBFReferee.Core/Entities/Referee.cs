using BBFReferee.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Entities
{
    public class Referee
    {
        public RoleOnGame RoleInGame { get; set; }
        public ICollection<Game> GameId { get; set; }
        
        public int UserId { get; set; }
        
        public int Mark { get; set; }
        public ICollection<Report> Report { get; set; }
        
        public int Id { get; set; }



    }
}
