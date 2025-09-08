namespace Application.Queries.BenefitQueries.Dtos;

public class OrderDto
{
    public string Id { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal? Value { get; set; }
    // Adicione outros campos conforme necessário
}
