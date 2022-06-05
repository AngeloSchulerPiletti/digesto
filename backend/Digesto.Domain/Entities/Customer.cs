namespace Digesto.Domain.Entities;

public class Customer : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public virtual List<InsuranceQuoteRequest> InsuranceQuoteRequests { get; set; }
}
