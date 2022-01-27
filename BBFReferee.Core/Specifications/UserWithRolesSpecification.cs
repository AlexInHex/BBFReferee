using BBFReferee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using BBFReferee.Core.Interfeices;

namespace BBFReferee.Core.Specifications
{
    public class UserWithRolesSpecification : ISpecification<User>
    {
        private int id;
        public IList<string> Includes =>
            new List<string> { $"{nameof(User.Roles)}.{nameof(UserRole.Role)}"  };

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
