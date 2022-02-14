using System.ComponentModel.DataAnnotations;

namespace BBFReferee.Web.Models
{
    public class SignInViewModel
    {
        [Required]
        public string Login { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
