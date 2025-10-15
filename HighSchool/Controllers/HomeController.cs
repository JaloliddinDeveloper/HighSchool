using Microsoft.AspNetCore.Mvc;

namespace HighSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public ActionResult<string> Get() =>
            "Hello HighSchool";
    }
}
