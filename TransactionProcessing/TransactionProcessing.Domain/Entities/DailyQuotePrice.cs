using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransactionProcessing.Domain.Entities;

public class DailyQuotePrice
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    public required string FundId { get; set; }
    public DateTime Date { get; set; }
    public decimal QuoteValue { get; set; }

    public DateTime CalculationTimestamp { get; set; }
}