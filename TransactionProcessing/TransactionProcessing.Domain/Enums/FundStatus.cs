using MongoDB.Bson.Serialization.Attributes;

namespace TransactionProcessing.Domain.Enums;

public enum FundStatus
{
    [BsonElement("active")]
    Active,

    [BsonElement("inactive")]
    Inactive,

    [BsonElement("liquidating")]
    Liquidating,

    [BsonElement("closed")]
    Closed,

    [BsonElement("suspended")]
    Suspended,

    [BsonElement("under_review")]
    UnderReview
}
