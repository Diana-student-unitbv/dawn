using BirthDayAPICore.Models;
using BirthDayAPICore.Services;
using Microsoft.AspNetCore.Mvc;

namespace BirthDayAPICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        IUsersCollectionService _usersCollectionService;
        public UsersController(IUsersCollectionService usersCollectionService) {
            _usersCollectionService = usersCollectionService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] User user)
        {
            var result =  _usersCollectionService.AddUser(user);
            return StatusCode(result ? 200 : 400);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok( _usersCollectionService.GetUsers());
            
        }
        /// <summary>
        /// return an annoucement by its ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("getByEmailPass/{email}/{pass}")]
        public ActionResult<User> GetById( string email, string pass)
        {
            var result = _usersCollectionService.GetUser(email, pass);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }


        }
    }
}
