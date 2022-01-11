using BBFReferee.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BBFReff.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }   
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string Email { get; set; }
        public int SityId { get; set; }
      
        public DateTime DateRegistration { get; set; }
        
        




    }
}
