namespace webapi.DTOs;

public class DishCreateDto
{
    public required string Name { get; set; }
    public required decimal Price { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    public required int CategoryId { get; set; }
}