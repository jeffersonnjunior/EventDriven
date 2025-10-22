using ActuarialBenefit.Domain.Enums;

namespace ActuarialBenefit.Domain.Entities;

public class Sponsor
{
    public required string SponsorId { get; set; }
    public required string Cnpj { get; set; }
    public required string CorporateName { get; set; }
    public SponsorStatus Status { get; set; }
}
