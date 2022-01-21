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
        int Add(User user);
        bool Update(User user);
        bool Delete(int id);
    }
}
