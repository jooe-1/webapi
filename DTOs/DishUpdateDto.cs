namespace webapi.DTOs;

public record DishUpdateDto
(
    string? Name,
    decimal? Price,
    string? ImageUrl,
    int? CategoryId
);