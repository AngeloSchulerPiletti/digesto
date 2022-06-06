using System.Text.Json.Serialization;

namespace Digesto.Domain.Entities;

public class Broker : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    [JsonIgnore]
    public string Password { get; set; }
    public virtual List<InsuranceQuoteRequest> InsuranceQuoteRequests { get; set; }
}
