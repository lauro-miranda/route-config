using LM.RouteConfig.Api.Domain.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LM.RouteConfig.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InfoController : ControllerBase
    {
        IInfoService InfoService { get; }

        public InfoController(IInfoService infoService)
        {
            InfoService = infoService;
        }

        [HttpGet, Route("simple"), Route("full")]
        public IActionResult GetInfo()
        {
            var info = InfoService.Get();
            return Ok(info);
        }
    }
}