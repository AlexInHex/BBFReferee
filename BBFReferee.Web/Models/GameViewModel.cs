using BBFReferee.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class GameViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Город")]
        public int SityId { get; set; }
       
        [Display(Name ="Дата игры")]
        public DateTime DateOfGame { get; set; }

        [Display(Name = "Команды")]
        public int TaemIds { get; set; }
        public ICollection<GameTeam> Teams { get; set; }
        
        [Display(Name ="Судьи")]
        public int RefereeId { get; set; }
        public Referee Referee { get; set; }
        public ICollection<Referee> referees { get; set; }

        [Display(Name = "Описание")]
        public string Describtion { get; set; }

        [Display(Name = "Сезон")]
        public int SeasonId { get; set; }
        public Season Season { get; set; }

        [Display(Name = "Номер игры")]
        public int GameNumberInSeasonId { get; set; }
    }
}
