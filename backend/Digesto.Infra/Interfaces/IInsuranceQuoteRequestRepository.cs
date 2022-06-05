using Digesto.Application.Models.DTO;
using Digesto.Domain.Entities;

namespace Digesto.Infra.Interfaces;

public interface IInsuranceQuoteRequestRepository
{
    public InsuranceQuoteRequest GetInsuranceQuoteRequest(uint id);
    public List<InsuranceQuoteRequest> GetInsuranceQuoteRequestsByBroker(PaginationDTO pagination, uint brokerId);
    public List<InsuranceQuoteRequest> GetInsuranceQuoteRequestsByCustomer(PaginationDTO pagination, uint customerId);
    public int GetTotalInsuranceQuoteRequestsByBroker(uint brokerId);
    public int GetTotalInsuranceQuoteRequestsByCustomer(uint customerId);
}
