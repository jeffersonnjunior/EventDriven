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
            _notifications.AddNotification("StatusInválido", "Não é possível adicionar participantes a um contrato que não está em rascunho.");
        }
        if (this._participants.Any(p => p.Cpf.Value == participant.Cpf.Value))
        {
            _notifications.AddNotification("CpfDuplicado", $"Participante com CPF {participant.Cpf.Value} já existe.");
        }

        _participants.Add(participant);
    }

    public void FinalizeContract(string contractNumberValue)
    {
        if (this.Status == ContractStatus.Closed)
        {
            _notifications.AddNotification("ContratoJáFinalizado", "Não é possível finalizar um contrato que já está finalizado.");
        }

        if (!this._participants.Any(p => p.Type == ParticipantType.Holder))
        {
            _notifications.AddNotification("SemTitular", "O contrato deve ter pelo menos um titular.");
        }

        if (string.IsNullOrWhiteSpace(contractNumberValue) || contractNumberValue.Length != 12)
        {
            _notifications.AddNotification("NúmeroContratóInválido", "O número do contrato deve ter 12 dígitos.");
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
