using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginTest.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginTest.Repository
{
    public class UserRepository : IUserRepository
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
