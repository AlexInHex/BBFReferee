using BBFReferee.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class ReportViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "Отчет")]
        [MaxLength(1000)]
        public string Describtion { get; set; }

        [HiddenInput]
        public DateTime DateCreation { get; set; }


        public Referee Referee { get; set; }
    }
}
