using BBFReferee.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class SeasonViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Название сезона")]
        public string Name { get; set; }

        [Display(Name = "Старт сезона")]
        public DateTime StartSeason { get; set; }

        [Display(Name = "Окончание сезона")]
        public DateTime EndSeason { get; set; }

        [Display(Name ="Игры")]
        public int GameIds;
        public IEnumerable<SelectList> Games { get; set; }
    }
}
