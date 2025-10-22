using ActuarialBenefit.Infrastructure.Enums;

namespace ActuarialBenefit.Domain.Entities;

public class Participant
{
    public Guid Id { get; set; }
    public required string RegistrationNumber { get; set; } 
    public required string FullName { get; set; }
    public required string Cpf { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string SponsorId { get; set; }
    public string PlanId { get; set; } 
    public ParticipantStatus Status { get; set; }
    public List<Dependent> Dependents { get; set; }
}
