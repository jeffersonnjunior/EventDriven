using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContractManagement.Domain.Entities;

public class ClientProfile
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Cpf { get; set; }
    public string FullName { get; set; }
    public string RiskProfile { get; set; } 
    public DateTime LastSuitabilityAssessment { get; set; }
}
