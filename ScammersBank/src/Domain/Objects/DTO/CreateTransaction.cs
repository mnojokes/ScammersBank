using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class CreateTransaction
{
    [Required] public int Id { get; set; }
    [Required] public decimal Amount { get; set; }
}
