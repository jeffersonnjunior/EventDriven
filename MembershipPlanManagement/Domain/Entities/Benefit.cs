using Domain.Enums;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Entities;

public class Benefit
{
    [BsonRepresentation(BsonType.String)]
    public required BenefitType Type { get; set; }
    public int? Age { get; set; }
    public required string Payout { get; set; }
    public required string Formula { get; set; }
}