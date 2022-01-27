using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;

        public UserService(IRepository<User> userRepository)
        {            
            this.userRepository = userRepository;
        }
        public int Add(User user)
        {
            userRepository.Add(user);
            return user.Id;
        }

        public User GetOne(int id)
        {
            return userRepository.Get(id);
        }

        public void Update(User user)
        {
            userRepository.Update(user);
        }

        public void Delete(int id)
        {
            var user = new User {Id = id};
            userRepository.Delete(user);
        }

        public IEnumerable<User> GetAll()
        {
            return userRepository.List();
        }
    }
}
