using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReff.Entities
{
    public class AdressTeam
    {
        public int Id { get; set; }
        public int SityId { get; set; }
        public Sity Sity { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public string Adress { get; set; }

    }
}
