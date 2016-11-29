using Microsoft.AspNetCore.Mvc;

namespace entityFramework.Web.Controllers
{
    [Route("api/temp")]
    public class TempController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hej");
        }
    }
}