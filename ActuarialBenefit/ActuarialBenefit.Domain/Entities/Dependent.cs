using ActuarialBenefit.Infrastructure.Enums;

namespace ActuarialBenefit.Domain.Entities;

public class Dependent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public RelationshipType Relationship { get; set; }
    public DateTime DateOfBirth { get; set; }
}
