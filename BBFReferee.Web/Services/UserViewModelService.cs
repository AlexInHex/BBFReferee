using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using BBFReferee.Web.Interfaces;
using BBFReferee.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
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
            return userService.Add(ConvertToEntity(userViewModel));
        }

        public void Edit(UserViewModel userViewModel)
        {
            userService.Update(ConvertToEntity(userViewModel));
        }

        public IEnumerable<UserViewModel> GetAll()
        {
            return (IEnumerable<UserViewModel>)userService.GetAll();
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
                Name = user.Name,
                Surname = user.Surname,
                Patronymic = user.Patronymic,
                DayOfBirth = user.DayOfBirth,
                Email = user.Email,
                SityId = user.SityId,
                AdressId = user.Adress,
                Login = user.Login,
                Password = user.Password,
                Roles = user.Roles
            };
        }
        private User ConvertToEntity(UserViewModel userViewModel)
        {
            return new User
            {
                Id = userViewModel.Id,
                Name = userViewModel.Name,
                Surname = userViewModel.Surname,
                Patronymic = userViewModel.Patronymic,
                DayOfBirth = userViewModel.DayOfBirth,
                Email = userViewModel.Email,
                SityId = userViewModel.SityId,
                Adress = new Adress { Adds = userViewModel.AdressId },
                Login = userViewModel.Login,
                Password = userViewModel.Password,
                Roles = userViewModel.Roles
            };
        }
    }
}
