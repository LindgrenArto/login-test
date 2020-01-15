using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginTest.Models;
using LoginTest.Service;

namespace LoginTest.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
       public ActionResult<User> ReadById(int id)
       {
            return new JsonResult(_userService.ReadById(id));
       }

       [HttpPost]
       public IActionResult AddUser([FromBody] User user)
        {
            return _userService.AddUser(user);
        }

        [HttpPost]
        public ActionResult<User> Login(User user)
        {
            return _userService.Login(user);
        }

        [HttpPut("{id}")]
        public ActionResult<User> Update(long id)
        {
            return _userService.Update(id);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(long id)
        {
            _userService.Delete(id);
            return new NoContentResult();
        }
    }
}