﻿namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.AppDbContextModels;

#region AggregatedCounter

public partial class AggregatedCounter
{
    public string Key { get; set; } = null!;

    public long Value { get; set; }

    public DateTime? ExpireAt { get; set; }
}

#endregion
