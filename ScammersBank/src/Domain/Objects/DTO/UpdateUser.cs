using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class UpdateUser
{
    [Required] public int Id { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
}
