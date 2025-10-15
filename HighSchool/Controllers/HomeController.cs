using Microsoft.AspNetCore.Mvc;

namespace HighSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get() =>
            "Hello HighSchool";
    }
}
