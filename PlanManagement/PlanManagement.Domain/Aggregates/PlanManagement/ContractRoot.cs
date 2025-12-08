using EventDriven.Domain.ValueObjects;
using PlanManagement.Domain.Aggregates.PlanManagement;

namespace EventDriven.Domain.Aggregates.PlanManagement;

public class ContractRoot
{
    public Guid Id { get; private set; }

    public string ContractNumberValue { get; private set; }

    public ProposalValue InitialValue { get; private set; }
    public ContractStatus Status { get; private set; } = ContractStatus.Draft;

    // Coleção de Entidades gerenciadas
    private readonly List<Participant> _participants = new List<Participant>();
    public IReadOnlyCollection<Participant> Participants => _participants.AsReadOnly();

    public ContractRoot(Guid id, ProposalValue initialValue)
    {
        this.Id = id;
        this.InitialValue = initialValue;
    }

    public void AddParticipant(Participant participant)
    {
        if (this.Status != ContractStatus.Draft)
        {
            throw new InvalidOperationException("Cannot add participants to a non-draft contract.");
        }
        if (this._participants.Any(p => p.Cpf.Value == participant.Cpf.Value))
        {
            throw new DomainRuleException($"Participant with CPF {participant.Cpf.Value} already exists.");
        }
        _participants.Add(participant);
    }

    public void FinalizeContract(string contractNumberValue)
    {
        if (this.Status == ContractStatus.Closed)
        {
            throw new ContractAlreadyClosedException(this.Id);
        }

        if (!this._participants.Any(p => p.Type == ParticipantType.Holder))
        {
            throw new DomainRuleException("Contract must have at least one holder.");
        }

        // 2. Validação da String ContractNumberValue (substituindo o Value Object)
        if (string.IsNullOrWhiteSpace(contractNumberValue) || contractNumberValue.Length != 12)
        {
            throw new ArgumentException("Contract Number must have 12 digits.", nameof(contractNumberValue));
        }

        // 3. Muda o estado
        this.ContractNumberValue = contractNumberValue;
        this.Status = ContractStatus.Closed;

        DomainEvents.Raise(new ContractClosedEvent(
            this.Id,
            this.ContractNumberValue,
            this.InitialValue.Amount,
            DateTime.UtcNow
        ));
    }
}

public enum ContractStatus { Draft, Closed, Active, Terminated }