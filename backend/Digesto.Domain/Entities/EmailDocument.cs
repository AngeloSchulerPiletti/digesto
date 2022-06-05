namespace Digesto.Domain.Entities
{
    public class EmailDocument : BaseEntity
    {
        public string Url { get; set; }
        public uint? InsuranceTypeId { get; set; }
        public virtual InsuranceType InsuranceType { get; set; }
        public uint EmailId { get; set; }
        public virtual Email Email { get; set; }
    }
}
