using System.Security.Claims;
using System.Text.Json.Serialization;

namespace webapi.Models;

public class User
{
    public int Id { get; set; }
    public required string Username { get; set; }
    [JsonIgnore] public string PasswordHash { get; set; } = null!;
    public string Role { get; set; } = "Cashier";

    public static bool IsValidRole(string role) => role is "Admin" or "Cashier" or "Chef";

    public static int GetIdFromUser(ClaimsPrincipal user)
    {
        var idClaim = user.FindFirst(ClaimTypes.NameIdentifier);
        return idClaim is not null ? int.Parse(idClaim.Value) : -1;
    }
}