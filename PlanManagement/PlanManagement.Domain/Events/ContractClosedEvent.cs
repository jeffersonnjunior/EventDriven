namespace EventDriven.Domain.Events;

public record ContractClosedEvent(
    Guid ContractId,
    string ContractNumber,
    decimal InitialContractValue,
    DateTime ClosureDate
);
