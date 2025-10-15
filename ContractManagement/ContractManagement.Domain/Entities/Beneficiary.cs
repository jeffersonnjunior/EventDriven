namespace ContractManagement.Domain.Entities;

public class Beneficiary
{
    public required string Name { get; set; }
    public decimal SharePercentage { get; set; }
    public required string Relationship { get; set; }
}
