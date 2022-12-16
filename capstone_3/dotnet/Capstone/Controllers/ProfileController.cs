using Capstone.DAO;
using Capstone.Models;
using Capstone.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using ShredClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace Capstone.Controllers
{
    [Route("[controller]")]
    [ApiController]
     [Authorize(Roles = "admin, user")]
    public class ProfileController : ControllerBase
    {
        private readonly IUserProfileDao userProfileDao;

        public ProfileController (IUserProfileDao _userProfileDao)
        {
            userProfileDao = _userProfileDao;
        }

        [HttpGet("{id}")]
        public IActionResult GetProfile(int id)
        {
           UserProfile profile =  userProfileDao.GetUserProfile(id);
           return Ok(profile);
        }
    
        [HttpPost]
        public IActionResult CreateProfile(UserProfile profile)
        {
            // Armageddon      95
            // The green Mile  497
            // The sixth Sense 745
            
            // thriller 53
            // Adventure 12
            // Action 28

            UserProfile userProfile = profile;



            userProfileDao.CreateUserProfile(profile);


            //userProfileDao.InsertUserProfile(userProfile.AboutMe, userProfile.UserId);
            //userProfileDao.InsertMovie(userProfileDao.MoviesToIds(userProfile.SeenMovies), userProfile.UserId);
            //userProfileDao.InsertGenres(userProfileDao.GenreToIds(userProfile.PickedGenres), userProfile.UserId);



            return Ok("OK");
        }
       
        [HttpDelete("{id}")]
        public IActionResult DeleteProfile(int  id)
        {
            if (!htua.IsAuthrizedUser(HttpContext, id))
            {
                return Unauthorized();
            }
            else
            {
                userProfileDao.DeleteUserProfile(id);
                return Ok(); 
            }


         //   userProfileDao.DeleteUserProfile(id);
          //  return Ok(id);
        }

        [HttpPut]
        public IActionResult UpdateProfile(UserProfile profile)
        {
            if (userProfileDao.UpdateProfile(profile))
            {
             return Ok("Ok");
            }
            return StatusCode(500);
        }

       
    }
}

