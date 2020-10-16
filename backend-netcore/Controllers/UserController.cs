using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
// using WebApi.Services;
using System.Threading.Tasks;
// using WebApi.Models;

namespace backend_netcore.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class UserController:ControllerBase
    {
        
    }
}