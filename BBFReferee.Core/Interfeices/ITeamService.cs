using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBFReferee.Core.Entities;

namespace BBFReferee.Core.Interfeices
{
    public interface ITeamService
    {
        Team GetOne(int id);
        IEnumerable<Team> GetAll();
        int Add(Team team);
        void Update(Team team);
        void Delete(int id);
    }
}
