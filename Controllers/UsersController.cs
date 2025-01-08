namespace Api.Controllers;

[ApiController]
[Route("api/v1/users")]
public class UsersController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet("")]
    public ActionResult<ServiceResponse<List<User>>> GetUsers()
    {
        return _userService.GetUsers();
    }

    [HttpGet("{id}")]
    public ActionResult<ServiceResponse<User>> GetUserById(int id)
    {
        ServiceResponse<User> serviceResponse = _userService.GetUserById(id);
        if(!serviceResponse.Success)
        {
            return NotFound(serviceResponse);
        }

        return Ok(serviceResponse);
    }
}

