using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginTest.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginTest.Service
{
    public class UserService : IUserService
    {
        public IQueryable AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable Login(User user)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> ReadById(int id)
        {
            throw new NotImplementedException();
        }

        public User Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
