using BBFReferee.Web.Models;
using System.Collections.Generic;

namespace BBFReferee.Web.Interfaces
{
    public interface IGameViewModelService
    {
        int Add(GameViewModel gameViewModel);
        void Edit(GameViewModel gameViewModel);
        IEnumerable<GameViewModel> GetAll();
        GameViewModel GetById(int id);
    }
}
