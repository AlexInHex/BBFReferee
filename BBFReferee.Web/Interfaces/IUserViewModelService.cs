
using BBFReferee.Web.Models;
using System.Collections.Generic;

namespace BBFReferee.Web.Interfaces
{
    public interface IUserViewModelService
    {
        int Add(UserViewModel userViewModel);
        void Edit(UserViewModel userViewModel);
        IEnumerable<UserViewModel> GetAll();
        UserViewModel GetById(int id);
    }
}
