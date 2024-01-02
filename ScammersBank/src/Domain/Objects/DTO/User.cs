using Domain.Objects.Entity;

namespace Domain.Objects.DTO;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int? AccountId1 { get; set; } = default;
    public int? AccountId2 { get; set; } = default;
}
