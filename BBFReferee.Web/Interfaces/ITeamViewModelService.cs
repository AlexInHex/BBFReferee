
using BBFReferee.Web.Models;
using System.Collections.Generic;

namespace BBFReferee.Web.Interfaces
{
    public interface ITeamViewModelService
    {
        int Add(TeamViewModel teamViewModel);
        void Edit(TeamViewModel teamViewModel);
        IEnumerable<TeamViewModel> GetAll();
        TeamViewModel GetById(int id);
    }
}
