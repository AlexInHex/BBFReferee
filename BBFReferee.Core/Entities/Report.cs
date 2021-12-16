using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReff.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string Describtion { get; set; }
        public DateTime DateCreation { get; set; }
        public int GameId { get; set; }
        public int UserId { get; set; }
        public ICollection<Referee> RefereeTeams { get; set; }


    }
}
