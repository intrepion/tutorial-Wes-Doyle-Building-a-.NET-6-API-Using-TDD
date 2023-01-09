using Microsoft.AspNetCore.Mvc;

namespace CloudCustomers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController()
    {
    }

    [HttpGet(Name = "GetUsers")]
    public void Get()
    {
    }
}
