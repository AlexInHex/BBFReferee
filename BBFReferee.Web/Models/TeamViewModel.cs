﻿using BBFReferee.Core.Entities;
using BBFReferee.Core.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class TeamViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Пол")]
        public static Gender GenderId { get; set; }
        public IEnumerable<SelectListItem> Genders { get; set; } = new List<SelectListItem>()
        { 
            new SelectListItem("-", ((int)Gender.None).ToString(), Gender.None == GenderId) 
        };

        [DataType(DataType.Password)]
        [Display(Name = "Название команды")]
        public string Name { get; set; }

        [Display(Name ="Адрес зала")]
        public ICollection<Adress> Adresses { get; set; }

        //public int HomeTeamId { get; set; }
        //public int AwayTeamId { get; set; }

        [Display(Name = "Игры")]
        public int GameIds;
        public ICollection<SelectListItem> Games { get; set; }

    }
}
