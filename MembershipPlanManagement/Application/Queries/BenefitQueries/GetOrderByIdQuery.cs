namespace Application.Queries.BenefitQueries;

public class GetOrderByIdQuery
{
    public string Id { get; set; }
    public GetOrderByIdQuery(string id)
    {
        Id = id;
    }
}
