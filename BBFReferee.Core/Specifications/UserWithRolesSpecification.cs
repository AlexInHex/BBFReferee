using BBFReferee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Specifications
{
    public class UserWithRolesSpecification
    {
        private int id;
        public IList<string> Includes =>
            new List<string> { $"{nameof(User.Roles)}, {nameof(Role.Name)}" };

        public UserWithRolesSpecification(int id)
        { 
            this.id = id;
        }

        public IQueryable<User> Apply(IQueryable<User> query)
        {
            return query.Where(x => x.Id == id);
        }
    }
}
