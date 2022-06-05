using Digesto.Application.Models.DTO;
using Digesto.Domain.Entities;

namespace Digesto.Infra.Interfaces;

public interface IEmailRepository
{
    public Email GetEmail(uint id);
    public List<Email> GetEmailsByBroker(PaginationDTO pagination, uint brokerId);
    public List<Email> GetEmailsByCustomer(PaginationDTO pagination, uint customerId);
    public List<Email> GetEmailsByInsuranceQuoteRequest(PaginationDTO pagination, uint insuranceQuoteRequestId);
    public int GetTotalEmailsByBroker(uint brokerId);
    public int GetTotalEmailsByCustomer(uint customerId);
    public int GetTotalEmailsByInsuranceQuoteRequest(uint insuranceQuoteRequestId);
}
