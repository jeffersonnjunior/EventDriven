namespace Domain.Entities;

public class PlanMembership
{
    public Guid PlanId { get; set; }
    public required string PlanName { get; set; }
    public List<Contribution> Contributions { get; set; } = new();
}
