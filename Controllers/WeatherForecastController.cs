using Microsoft.AspNetCore.Mvc;

namespace aspnetcore.Controllers;

[ApiController]
[Route("test")]
public class WeatherForecastController : ControllerBase
{

    [HttpGet]
    public IActionResult Get([FromQuery] Dictionary<string, string> test = null)
    {
        return Ok("test 123");
    }
}
