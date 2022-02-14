using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Specifications
{
    public class UserByLoginSpecification : ISpecification<User>
    {
        private string login;
        public IList<string> Includes =>
            new List<string> { $"{nameof(User.Roles)}.{nameof(UserRole.Role)}" };

        public UserByLoginSpecification(string login)
        {
            this.login = login;
        }

        public IQueryable<User> Apply(IQueryable<User> query)
        {
            return query.Where(i => i.Login == login);
        }
    }
}
