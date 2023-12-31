using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class UpdateAccount
{
    [Required] public int Id { get; set; }
    [Required] public string Type { get; set; }
}
