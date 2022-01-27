using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBFReferee.Core.Entities;

namespace BBFReferee.Core.Interfeices
{
    public interface IGameService
    {
        Game GetOne(int id);
        IEnumerable<Game> GetAll();
        int Add(Game game);
        void Update(Game game);
        void Delete(int id);
    }
}
