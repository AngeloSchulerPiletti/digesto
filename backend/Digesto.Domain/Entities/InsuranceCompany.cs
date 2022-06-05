namespace Digesto.Domain.Entities;

public class InsuranceCompany
{
    public string Name { get; set; }
    public string ContactEmail { get; set; }
    public string Code { get; set; }
    public virtual List<InsuranceType> AvailableInsuranceTypes { get; set; }
}
