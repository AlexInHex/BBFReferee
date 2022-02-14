using BBFReferee.Web.Models;
using System.Collections.Generic;

namespace BBFReferee.Web.Interfaces
{
    public interface ISityViewModelService
    {
        int Add(SityViewModel sityViewModel);
        void Edit(SityViewModel sityViewModel);
        IEnumerable<SityViewModel> GetAll();
        SityViewModel GetOne(int id);
    }
}
