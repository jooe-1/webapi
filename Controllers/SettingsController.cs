using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SettingsController : ControllerBase
{
    [HttpPut("appearance")]
    public IActionResult UpdateTheme([FromBody] string theme) {  return Ok(); }

    [HttpGet("staff")]
    public IActionResult GetStaff() { return Ok(); }
}