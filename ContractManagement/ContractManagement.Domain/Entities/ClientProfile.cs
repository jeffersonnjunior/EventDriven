using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContractManagement.Domain.Entities;

public class ClientProfile
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    public required string Cpf { get; set; }
    public required string FullName { get; set; }
    public required string RiskProfile { get; set; } 
    public DateTime LastSuitabilityAssessment { get; set; }
}
