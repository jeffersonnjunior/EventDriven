using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ContractManagement.Domain.Entities;

public class Contract
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string ClientId { get; set; } 
    public string PlanType { get; set; } 
    public string TaxRegime { get; set; } 
    public string Status { get; set; } 
    public decimal AdministrationFee { get; set; }
    public DateTime CreationDate { get; set; }
    public List<Beneficiary> Beneficiaries { get; set; } = new List<Beneficiary>();
}
