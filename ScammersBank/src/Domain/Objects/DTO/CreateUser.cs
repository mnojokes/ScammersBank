using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class CreateUser
{
    [Required] public string Name { get; set; } = string.Empty;
    [Required] public string Address { get; set; } = string.Empty;
}
