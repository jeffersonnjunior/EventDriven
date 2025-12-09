using EventDriven.Domain.ValueObjects;
using PlanManagement.Domain.Aggregates.PlanManagement;
using Domain.Exceptions;
using EventDriven.Domain.Events;
using EventDriven.Domain.Enums;

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

    private readonly NotificationContext _notifications;

    public ContractRoot(Guid id, ProposalValue initialValue)
    {
        this.Id = id;
        this.InitialValue = initialValue;
        _notifications = new NotificationContext();
    }

    public void AddParticipant(Participant participant)
    {
        if (this.Status != ContractStatus.Draft)
        {
            _notifications.AddNotification("InvalidStatus", "Cannot add participants to a non-draft contract.");
        }
        if (this._participants.Any(p => p.Cpf.Value == participant.Cpf.Value))
        {
            _notifications.AddNotification("DuplicateCpf", $"Participant with CPF {participant.Cpf.Value} already exists.");
        }

        _participants.Add(participant);
    }

    public void FinalizeContract(string contractNumberValue)
    {
        if (this.Status == ContractStatus.Closed)
        {
            _notifications.AddNotification("ContractAlreadyClosed", "Cannot finalize a contract that is already closed.");
        }

        if (!this._participants.Any(p => p.Type == ParticipantType.Holder))
        {
            _notifications.AddNotification("NoHolders", "Contract must have at least one holder.");
        }

        if (string.IsNullOrWhiteSpace(contractNumberValue) || contractNumberValue.Length != 12)
        {
            _notifications.AddNotification("InvalidContractNumber", "Contract Number must have 12 digits.");
        }

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
