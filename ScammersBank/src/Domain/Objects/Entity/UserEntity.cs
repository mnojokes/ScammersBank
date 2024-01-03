namespace Domain.Objects.Entity;

public class UserEntity
{
    public int Id { get; set; } = default;
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsDeleted { get; set; } = false;
}
