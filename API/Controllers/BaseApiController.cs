using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    // Base Class which will inherits in all other class
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }
}