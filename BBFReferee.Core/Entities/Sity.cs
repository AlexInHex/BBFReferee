using System.Collections.Generic;

namespace BBFReferee.Core.Entities
{
    public class Sity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
       

    }
}
