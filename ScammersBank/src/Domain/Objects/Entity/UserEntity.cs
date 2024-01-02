using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Entity;

public class UserEntity
{
    public int Id { get; set; } = default;
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int? AccountId1 { get; set; } = default;
    public int? AccountId2 { get; set; } = default;
    public bool IsDeleted { get; set; } = false;
}
