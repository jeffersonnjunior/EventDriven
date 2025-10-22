namespace Shared.Base;

public abstract class IntegrationEvent
{
    public Guid EventId { get; } = Guid.NewGuid();
    public DateTime Timestamp { get; } = DateTime.UtcNow;
    public int Version { get; } = 1;
}
