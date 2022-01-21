using BBFReferee.Core.Entities;
using BBFReferee.Core.Interfeices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBFReferee.Core.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserService userService;
        private readonly IRepository<User> userRepository;

        public UserService(IUserService userService, IRepository<User> userRepository)
        {
            this.userService = userService;
            this.userRepository = userRepository;
        }
        public int Add(User user)
        {
            return userService.Add(user);
        }

        public User GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
