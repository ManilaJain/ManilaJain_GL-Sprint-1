using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using projectAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace projectAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            var UsersList = new List<User>();
            // Call repository layer to get all users
            // UsersList = UserRepository.GetAllUsers();
            return UsersList;
        }

        [HttpGet]
        [Route("{userId}")]
        public User GetUser(int userId)
        {
            var user = new User();
            // Call repository layer to get user
            // user = UserRepository.GetUser();
            return user;
        }

        [HttpPut]
        public bool UpdateUser([FromBody] User userDetail)
        {
            bool userUpdated = false;
            // Call repository layer to update user
            // userUpdated = UserRepository.UpdateUser(userDetail);
            return userUpdated;
        }

        [HttpPost]
        public bool CreateUser([FromBody] User userDetail)
        {
            bool userCreated = false;
            // Call repository layer to update user
            // userCreated = UserRepository.CreateUser(userDetail);
            return userCreated;
        }

    }
}
