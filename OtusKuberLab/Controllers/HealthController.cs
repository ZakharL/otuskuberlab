using Microsoft.AspNetCore.Mvc;

namespace OtusKuberLab.Controllers
{
    [ApiController]
    [Route( "[controller]" )]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "{\"status\": \"OK\"}";
        }
    }
}
