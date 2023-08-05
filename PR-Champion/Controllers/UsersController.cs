using Microsoft.AspNetCore.Mvc;

namespace PR_Champion.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetUsers()
        {
            return new JsonResult(
                new List<object> {
                    new {id = 1, name = "conrad"},
                    new {id = 2, name = "bill"}
                }
                );
        }
    }
}
