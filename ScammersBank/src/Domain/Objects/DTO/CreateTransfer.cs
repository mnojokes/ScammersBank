namespace Domain.Objects.DTO;

public class CreateTransfer
{
    public int? FromAccountId { get; set; } = default;
    public int? ToAccountId { get; set; } = default;
    public decimal Amount { get; set; } = default;
}
