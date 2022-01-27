using BBFReferee.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Имя")]
        [MaxLength(30)]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Display(Name = "Роли")]
        public int RoleIds;
        public IList<SelectListItem> Roles { get; set; }

        [Display(Name = "Города")]
        public int SityId { get; set; }
        public IEnumerable<SelectListItem> Sities { get; set; }

        [Display(Name = "Адрес")]
        public string AdressId { get; set; }

        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Почта")]
        public string Email { get; set; }


        [Display(Name = "Дата рождения")]
        public DateTime DayOfBirth { get; set; }

        //[HiddenInput]
        //[Display(Name = "Дата регистрации")]
        public DateTime DateRegistration { get; set; }
      
      
    
    }
}
