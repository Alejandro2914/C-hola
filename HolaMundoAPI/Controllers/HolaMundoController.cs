using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HolaMundoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hola Mundo desde Railway!");
    }
}