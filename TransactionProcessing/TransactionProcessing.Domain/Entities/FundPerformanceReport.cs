using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TransactionProcessing.Domain.Entities;

public class FundPerformanceReport
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public Guid Id { get; set; }
    public required string FundId { get; set; }
    public required string ReportPeriod { get; set; }
    public decimal NetReturnRate { get; set; }
    public decimal GrossReturnRate { get; set; }
    public decimal TotalAssetsUnderManagement { get; set; }
    public DateTime ReportGenerationDate { get; set; }
}