using EventDriven.Domain.Enums;
using EventDriven.Domain.ValueObjects;

namespace PlanManagement.Domain.Aggregates.PlanManagement;

public class Participant
{
    public Guid Id { get; }
    public string Name { get; private set; }
    public ParticipantType Type { get; private set; }
    public Cpf Cpf { get; private set; }

    public Participant(Guid id, string name, ParticipantType type, Cpf cpf)
    {
        this.Id = id;
        this.Name = name;
        this.Type = type;
        this.Cpf = cpf;
    }
}
