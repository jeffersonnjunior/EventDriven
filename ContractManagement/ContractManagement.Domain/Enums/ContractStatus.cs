using MongoDB.Bson.Serialization.Attributes;

namespace ContractManagement.Domain.Enums;

public enum ContractStatus
{
    [BsonElement("rascunho")]
    Draft,

    [BsonElement("ativo")]
    Active,

    [BsonElement("suspenso")]
    Suspended,

    [BsonElement("encerrado")]
    Terminated,

    [BsonElement("expirado")]
    Expired,

    [BsonElement("em_analise")]
    UnderReview
}
