using Microsoft.AspNetCore.Mvc;

namespace AlphaEngine.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get(int id)
        {
            return $"this record has {id}";
        }

    }
}