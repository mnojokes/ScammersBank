using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class UpdateAccount
{
    [Required] public int Id { get; set; } = default;
    [Required] public string Type { get; set; } = string.Empty;
}
