namespace Digesto.Domain.Entities
{
    public class InsuranceType : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<InsuranceCompany> AvailableInsuranceCompanies { get; set; }
        public virtual List<EmailDocument> EmailDocuments { get; set; }
        public virtual List<IndependentDocument> IndependentDocuments { get; set; }
    }
}
