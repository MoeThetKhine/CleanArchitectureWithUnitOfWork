﻿namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.AppDbContextModels;

public partial class Counter
{
    public string Key { get; set; } = null!;

    public int Value { get; set; }

    public DateTime? ExpireAt { get; set; }

    public long Id { get; set; }
}
