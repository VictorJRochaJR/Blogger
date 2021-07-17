using Microsoft.AspNetCore.Mvc;
using Blogger.Models;
using Blogger.Service;
using System.Collections.Generic;

namespace Blogger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ProfileService _profileService;
        public ProfileController(ProfileService profileService, BlogsService blogsService)
        {
            _profileService  = profileService;
            
        }
        [HttpGet("{id}")]
        public  ActionResult<Profile> Get(string id)
        {
            try
            {
                Profile foundProfile =  _profileService.Get(id);
                return  foundProfile;
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Profile> CreateProfile([FromBody] Profile profileData)
        {
            try
            {
                var profile = _profileService.CreateProfile(profileData);
                return Created("api/recipes/" + profile.Id, profile);
            }
            catch (System.Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }


        [HttpGet("{id}/blogs")]
        public ActionResult<IEnumerable<Blog>>GetBlogByProfileId(string id);
        {
            try
            {
                return Ok(_)
                
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
        }

    }
}