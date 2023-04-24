using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ConsiderTheSourceCode.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
       
    }
}
