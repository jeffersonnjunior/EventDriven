using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FundPerformanceManagement.Domain.Entities;

public class TransactionJournal
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    public Guid ContractId { get; set; }
    public string TransactionType { get; set; } 
    public decimal ValueBRL { get; set; }
    public decimal QuotesProcessed { get; set; } 
    public decimal QuotePriceAtTransaction { get; set; } 
    public DateTime EffectiveDate { get; set; }
    public string Status { get; set; } 
}