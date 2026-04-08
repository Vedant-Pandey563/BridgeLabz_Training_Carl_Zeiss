using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PingController : ControllerBase
    {
        //get 
        [HttpGet]
        public IActionResult GetPing()
        {
            var response = new
            {
                message = "pong",
                status = 200,
                timestamp = DateTime.UtcNow
            };

            return Ok(response);
        }
    }
}
