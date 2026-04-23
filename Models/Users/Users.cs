namespace webapi.Models.Users;

public class Users
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; } // في الحقيقة بنعمل لها Hashing
    public string Role { get; set; } // "Admin" أو "Cashier"
}
