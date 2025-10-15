using MongoDB.Bson.Serialization.Attributes;

namespace FundPerformanceManagement.Domain.Entities;

public class AccountBalance
{
    [BsonId]
    public string Id { get; set; }
    public decimal CurrentQuotes { get; set; }
    public string CurrentFundId { get; set; } 
    public decimal LastKnownQuotePrice { get; set; }
    public DateTime LastUpdateTimestamp { get; set; }
}