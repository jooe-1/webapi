using Microsoft.EntityFrameworkCore;
using webapi.Models.Dishes;
using webapi.Models.Orders;
using webapi.Models.Users;

namespace webapi.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<Dishes> Dishes { get; set; }
    public DbSet<Orders> Orders { get; set; }
    public DbSet<Users> Users { get; set; } 
}