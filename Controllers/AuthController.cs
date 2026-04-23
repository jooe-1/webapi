using Microsoft.AspNetCore.Mvc;
using webapi.Data; // مهم جداً عشان يشوف الـ AppDbContext
using webapi.Models.Users;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // 1. تعريف المتغير
    private readonly AppDbContext _context;

    // 2. الـ Constructor اللي بيخلي الـ _context موجودة
    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] Users loginInfo)
    {
        // دلوقتي الـ _context بقت موجودة وتقدر تستخدمها هنا
        var user = _context.Users.FirstOrDefault(u => u.Username == loginInfo.Username && u.Password == loginInfo.Password);
        
        if (user == null) return Unauthorized();
        return Ok(user);
    }
}