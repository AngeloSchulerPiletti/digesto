namespace Digesto.Domain.Entities;

public class InsuranceQuoteRequest : BaseEntity
{
    public uint BrokerId { get; set; }
    public virtual Broker Broker { get; set; }
    public virtual uint CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
    public virtual List<Email> Emails { get; set; }
    public virtual List<IndependentDocument> IndependentDocuments { get; set; }

}
