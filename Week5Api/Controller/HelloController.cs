using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Week5Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok("Hello from your Azure API running .NET 9");
        }
    }
}
