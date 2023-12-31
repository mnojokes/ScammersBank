using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Objects.Entity;

public class UserEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int? AccountId1 { get; set; } = null;
    public int? AccountId2 { get; set; } = null;
    public bool IsDeleted { get; set; } = false;
}
