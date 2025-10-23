using ActuarialBenefit.Infrastructure.Enums;
using ActuarialBenefit.Domain.ValueObjects;

namespace ActuarialBenefit.Domain.Entities;

public class Participant
{
    public required string ParticipantId { get; set; }
    public required string RegistrationNumber { get; set; }
    public required string PlanId { get; set; }
    public required string SponsorId { get; set; }
    public required string FullName { get; set; }
    public required Cpf Cpf { get; set; }
    public decimal CurrentSalary { get; set; }
    public ParticipantStatus Status { get; set; }
    public List<Dependent> Dependents { get; set; } = new();
}