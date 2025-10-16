using MongoDB.Bson.Serialization.Attributes;

namespace FundPerformanceManagement.Domain.Enums;

public enum TransactionStatus
{
    [BsonElement("pendente")]
    Pending,

    [BsonElement("processando")]
    Processing,

    [BsonElement("concluida")]
    Completed,

    [BsonElement("falhada")]
    Failed,

    [BsonElement("cancelada")]
    Cancelled,

    [BsonElement("em_espera")]
    OnHold
}