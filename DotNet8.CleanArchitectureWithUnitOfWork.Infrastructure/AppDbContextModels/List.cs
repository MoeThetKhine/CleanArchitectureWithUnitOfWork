using System;
using System.Collections.Generic;

namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.AppDbContextModels;

public partial class List
{
    public long Id { get; set; }

    public string Key { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}
