namespace Digesto.Domain.Entities
{
    public class IndependentDocument
    {
        public string Url { get; set; }
        public uint? InsuranceTypeId { get; set; }
        public virtual InsuranceType InsuranceType { get; set; }
        public uint InsuranceQuoteRequestId { get; set; }
        public virtual InsuranceQuoteRequest InsuranceQuoteRequest { get; set; }
    }
}
