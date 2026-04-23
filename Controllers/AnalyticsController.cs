using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class AnalyticsController : ControllerBase
{
    [HttpGet("summary")]
    public IActionResult GetDashboardSummary() 
    {
        return Ok(new { TotalRevenue = 10243.00, MostOrdered = "Spicy Noodles" });
    }
}