using BirthDayAPICore.Models;
using BirthDayAPICore.Services;
using Microsoft.AspNetCore.Mvc;

namespace BirthDayAPICore.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class BirthDayController : Controller
    {
        IBirthDayCollectionService _bdCollectionService;
        public BirthDayController(IBirthDayCollectionService bdCollectionService)
        {
            _bdCollectionService = bdCollectionService;
        }

        [HttpGet("{userId}")]
        public IActionResult GetAll([FromRoute] int userId)
        {
            return Ok(_bdCollectionService.GetBirthDaysFriends(userId));

        }

        [HttpPost]
        public IActionResult Add([FromBody] BirthDay bd)
        {
            return Ok(_bdCollectionService.AddBirthDay(bd));


        }
    }
}
