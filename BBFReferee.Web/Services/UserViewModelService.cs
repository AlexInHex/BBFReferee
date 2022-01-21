using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BBFReferee.Web.Services
{
    public class UserViewModelService : IUserViewModelService
    {
        private readonly IUserService userService;
        private readonly IRepository<User> userRepository;
        public UserViewModelService(IUserService userService, IRepository<User> userRepositiry)
        {
            this.userService = userService;
            this.userRepository = userRepositiry;
        }
        
        public int Add(UserViewModel userViewModel)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(UserViewModel userViewModel)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public UserViewModel GetById(int id)
        {
            var user = userService.GetOne(id);
            return user != null ? ConvertToViewModel(user) : null;
        }

        private UserViewModel ConvertToViewModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Name = user.Name
            };
        }
    }
}
