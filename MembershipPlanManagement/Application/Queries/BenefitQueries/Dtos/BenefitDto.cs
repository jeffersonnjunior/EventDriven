using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Application.Queries.BenefitQueries.Dtos;

public class BenefitDto
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;
    public string? Type { get; set; }
    public int Age { get; set; }
    public decimal Payout { get; set; }
    public string? Formula { get; set; }
}
