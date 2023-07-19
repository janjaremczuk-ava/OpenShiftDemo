using Microsoft.AspNetCore.Mvc;

namespace OpenShiftDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "demo")]
        public ActionResult<string> GetDemoMsg()
        {
            var message = "Hello OpenShift";
            return message;
        }
    }
}