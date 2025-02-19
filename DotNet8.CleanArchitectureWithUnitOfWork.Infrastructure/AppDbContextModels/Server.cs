namespace DotNet8.CleanArchitectureWithUnitOfWork.Infrastructure.AppDbContextModels;

public partial class Server
{
    public string Id { get; set; } = null!;

    public string? Data { get; set; }

    public DateTime LastHeartbeat { get; set; }
}
