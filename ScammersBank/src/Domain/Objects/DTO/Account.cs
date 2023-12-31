using Domain.Objects.CustomTypes;

namespace Domain.Objects.DTO;

public class Account
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public int HolderId { get; set; }
    public bool IsClosed { get; set; }
}
