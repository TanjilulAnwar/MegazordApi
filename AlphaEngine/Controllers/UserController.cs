using Microsoft.AspNetCore.Mvc;

namespace AlphaEngine.Controllers
{
//http://localhost:5235/swagger/index.html
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