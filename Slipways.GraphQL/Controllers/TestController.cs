using Microsoft.AspNetCore.Mvc;

namespace Slipways.GraphQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get() => Ok();
    }
}