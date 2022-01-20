using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class UserViewModel
    {
        [HiddenInput]
        public int Id { get; set; }

        [Display(Name = "my name")]
        public string Name { get; set; }

        public IList<string> Roles { get; set; }
    }
}
