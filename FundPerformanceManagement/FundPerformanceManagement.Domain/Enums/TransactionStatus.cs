using MongoDB.Bson.Serialization.Attributes;

namespace FundPerformanceManagement.Domain.Enums;

public enum TransactionStatus
{
    [BsonElement("pending")]
    Pending,

    [BsonElement("processing")]
    Processing,

    [BsonElement("completed")]
    Completed,

    [BsonElement("failed")]
    Failed,

    [BsonElement("cancelled")]
    Cancelled,

    [BsonElement("on_hold")]
    OnHold
}