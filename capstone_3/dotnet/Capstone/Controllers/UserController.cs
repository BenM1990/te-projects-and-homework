using Capstone.DAO;
using Capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
  //  [Authorize(Roles = "admin, user")]                   
    public class UserController : ControllerBase
        {

            private readonly IUserDao userDao;
            public UserController(IUserDao _userDao)
            {
                userDao = _userDao;
            }
            [HttpDelete("/{id}")]
            
            public IActionResult DeleteUser(int id)
            {
                bool result = userDao.DeleteUser(id);
                if (result)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
    }
}
