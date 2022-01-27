using BBFReferee.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class SityViewModel
    {
        public class Sity
        {
            [HiddenInput]
            public int Id { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Город")]
            public string Name { get; set; }
           

        }
    }
}
