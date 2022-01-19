using System;
using System.Collections.Generic;

namespace BBFReferee.Core.Entities
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
        public DateTime DateRegistration { get; set; }
        public Adress Adress { get; set; }
        public Sity Sity { get; set; }
        public ICollection<UserRole> Roles { get; set; }


    }
}
