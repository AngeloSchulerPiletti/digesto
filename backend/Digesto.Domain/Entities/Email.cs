namespace Digesto.Domain.Entities;

public class Email : BaseEntity
{
    public uint InsuranceQuoteRequestId { get; set; }
    public virtual InsuranceQuoteRequest InsuranceQuoteRequest { get; set; }
    public virtual List<EmailDocument> EmailDocuments { get; set; }
}
