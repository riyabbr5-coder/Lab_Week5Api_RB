using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week5Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Your API has been updated through CI and CD");
        }
    }
}
