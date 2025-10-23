using ActuarialBenefit.Domain.Enums;
using ActuarialBenefit.Domain.ValueObjects;

namespace ActuarialBenefit.Domain.Entities;

public class Sponsor
{
    public required string SponsorId { get; set; }
    public required Cnpj Cnpj { get; set; }
    public required string CorporateName { get; set; }
    public SponsorStatus Status { get; set; }
}