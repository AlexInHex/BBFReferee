using BBFReferee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Interfeices
{
    public interface IUserService
    {
        User GetOne(int id);
        User GetOne(string login);
        IEnumerable<User> GetAll();
        int Add(User user);
        void Update(User user);
        void Delete(int id);
    }
}
