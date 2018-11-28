using Microsoft.AspNetCore.Mvc;

namespace HelloNetCoreOnK8s.Controllers
{
    
    [Route("api/describe")]
    public class DescribeController : Controller
    {
        [HttpGet]
        public IActionResult GetDescription()
        {
            return Json(new {Program.InstanceId});
        }
    }
}