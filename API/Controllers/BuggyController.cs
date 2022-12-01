using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;
        public BuggyController(DataContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet("Auth")]
        public ActionResult<string> GetSecret()
        {
            return "Secret text";
        }

        [HttpGet("Not-Found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.Users.Find(-1);

            if (thing == null) return NotFound();

            return Ok(thing);
        }

        [HttpGet("Server-Error")]
        public ActionResult<string> GetServerError()
        {
            var thing = _context.Users.Find(-1);

            string thingToReturn = thing.ToString();

            return thingToReturn;
        }

        [HttpGet("Bad-Request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("This was not a good request");
        }
    }
}