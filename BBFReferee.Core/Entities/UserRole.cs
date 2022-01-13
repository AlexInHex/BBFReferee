using System;

namespace BBFReferee.Core.Entities
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
       
        public DateTime MemberOn { get; set; }

    }
}
