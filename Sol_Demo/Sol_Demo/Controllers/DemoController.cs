using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sol_Demo.Core;

namespace Sol_Demo.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("get/small")]
        public IActionResult GetSmallCache([FromKeyedServices(CacheDemoEnum.Small)] ICacheDemo cacheDemo)
        {
            return Ok(cacheDemo.Get("Hello-small"));
        }

        [HttpGet("get/big")]
        public IActionResult GetBigCache([FromKeyedServices(CacheDemoEnum.Big)] ICacheDemo cacheDemo)
        {
            return Ok(cacheDemo.Get("Hello-big"));
        }
    }
}