using MongoDB.Bson.Serialization.Attributes;

namespace FundPerformanceManagement.Domain.Enums;

public enum FundStatus
{
    [BsonElement("ativo")]
    Active,

    [BsonElement("inativo")]
    Inactive,

    [BsonElement("liquidando")]
    Liquidating,

    [BsonElement("fechado")]
    Closed,

    [BsonElement("suspenso")]
    Suspended,

    [BsonElement("em_analise")]
    UnderReview
}