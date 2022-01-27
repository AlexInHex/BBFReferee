using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBFReferee.Core.Entities;

namespace BBFReferee.Core.Interfeices
{
    public interface ISityService
    {
        Sity Add(Sity sity);
        Sity Update(Sity sity);
        void Delete(int id);
        List<Sity> GetAll();
        Sity Get(int id);


    }
}
