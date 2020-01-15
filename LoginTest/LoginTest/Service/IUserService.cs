using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoginTest.Models;

namespace LoginTest.Service
{
    public interface IUserService
    {
        IQueryable AddUser(User user);
        IQueryable Login(User user);
        IQueryable<User> ReadById(int id);
        User Update(User user);
        void Delete(long id);
    }
}
