using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectAPI.Controllers
{
    [Route("api/login/{userId}/{password}")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpGet]
        public bool LoginUser(int userId, string password)
        {
            var loginSuccessful = false;
            // call repository to login user
            // loginSuccessful = loginRepository.verifyDetails(userId,password);
            return loginSuccessful;
        }
    }
}
