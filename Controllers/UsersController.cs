namespace Api.Controllers;

[ApiController]
[Route("api/v1/users")]
public class UsersControllers : ControllerBase
{
    [HttpGet]
    public ActionResult TestGet()
    {
        return Ok("salut romain");
    }
}