using Shared.Base;

namespace Shared.Events.ActuarialBenefit;

public class ParticipantEnrolledEvent : IntegrationEvent
{
    public string ParticipantId { get; init; }
    public string RegistrationNumber { get; init; }
    public string PlanId { get; init; }    
    public string SponsorId { get; init; } 
    public decimal BaseSalary { get; init; }
    public DateTime EnrollmentDate { get; init; }

    public ParticipantEnrolledEvent(string participantId, string regNumber, string planId, string sponsorId, decimal baseSalary, DateTime enrollmentDate)
    {
        ParticipantId = participantId;
        RegistrationNumber = regNumber;
        PlanId = planId;
        SponsorId = sponsorId;
        BaseSalary = baseSalary;
        EnrollmentDate = enrollmentDate;
    }
}
