namespace EventDriven.Domain.ValueObjects;

public class ProposalValue
{
    public decimal Amount { get; }

    public ProposalValue(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Proposal value must be positive.", nameof(amount));
        }
        this.Amount = amount;
    }
}