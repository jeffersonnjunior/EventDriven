namespace Domain.Entities;

public class Membership
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<PlanMembership> Plans { get; set; } = new();
}
