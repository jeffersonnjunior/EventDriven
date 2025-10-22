using ActuarialBenefit.Infrastructure.Enums;

namespace ActuarialBenefit.Domain.Entities;

public class Dependent
{
    public Guid DependentId { get; set; }
    public required string Name { get; set; }
    public RelationshipType Relationship { get; set; }
    public DateTime DateOfBirth { get; set; }
}
