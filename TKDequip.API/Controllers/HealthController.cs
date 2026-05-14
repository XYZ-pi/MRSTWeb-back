using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TKDequip.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}
