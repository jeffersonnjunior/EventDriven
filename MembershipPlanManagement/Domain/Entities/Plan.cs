using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Domain.Enums;

namespace Domain.Entities;

public class Plan
{
    public Guid PlanId { get; set; }
    public required string Name { get; set; }
    public decimal MonthlyContribution { get; set; }
    [BsonRepresentation(BsonType.String)]
    public required PlanType Type { get; set; }
    public List<Benefit> Benefits { get; set; } = new();
}