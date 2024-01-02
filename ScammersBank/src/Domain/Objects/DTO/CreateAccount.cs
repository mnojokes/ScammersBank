using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class CreateAccount
{
    [Required] public string Type { get; set; } = string.Empty;
    [Required] public int HolderId { get; set; } = default;
}
