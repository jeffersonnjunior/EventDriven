namespace Domain.Entities;

public class Contribution
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }            
    public decimal Amount { get; set; }           
    public string? PlanMembershipId { get; set; } 
    public string? Description { get; set; }     
}