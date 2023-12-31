namespace Domain.Objects.DTO;

public class CreateTransfer
{
    public int? FromAccountId { get; set; } = null;
    public int? ToAccountId { get; set; } = null;
    decimal Amount { get; set; } = 0m;
}
