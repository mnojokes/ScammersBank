using System.ComponentModel.DataAnnotations;

namespace Domain.Objects.DTO;

public class CreateTransaction
{
    [Required] public int AccountId { get; set; } = default;
    [Required] public decimal Amount { get; set; } = default;
}
