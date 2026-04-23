using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.Models.Orders;

[ApiController] [Route("api/[controller]")]
public class OrdersController : ControllerBase 
{
    private readonly AppDbContext _context;

    public OrdersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("checkout")]
    public IActionResult Checkout([FromBody] Orders order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges(); 
        return Ok(new { OrderId = order.Id, Status = "Order Saved Permanently" });
    }
}