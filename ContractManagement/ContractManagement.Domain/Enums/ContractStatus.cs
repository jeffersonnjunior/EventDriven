using MongoDB.Bson.Serialization.Attributes;

namespace ContractManagement.Domain.Enums;

public enum ContractStatus
{
    [BsonElement("draft")]
    Draft,
    
    [BsonElement("active")]
    Active,
    
    [BsonElement("suspended")]
    Suspended,
    
    [BsonElement("terminated")]
    Terminated,
    
    [BsonElement("expired")]
    Expired,
    
    [BsonElement("under_review")]
    UnderReview
}
