using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class UpdateUser
{
    [Required] public int Id { get; set; } = default;
    public string? Name { get; set; } = default;
    public string? Address { get; set; } = default;
}
