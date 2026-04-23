using Microsoft.AspNetCore.Mvc;
using webapi.Data;
using webapi.Models.Dishes;

[ApiController] [Route("api/[controller]")]
public class DishesController : ControllerBase 
{
    private readonly AppDbContext _context; // بنعرف المتغير هنا

    public DishesController(AppDbContext context) // الـ Constructor اللي بيسحب الداتابيز
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get() => Ok(_context.Dishes.ToList()); // بيسحب من الجدول بجد

    [HttpPost]
    public IActionResult Post([FromBody] Dishes newDish) 
    {
        _context.Dishes.Add(newDish); // بيضيف للجدول
        _context.SaveChanges();      // سيف التعديلات في ملف الـ .db
        return Ok(new { Message = "Dish saved to DB!" });
    }
}